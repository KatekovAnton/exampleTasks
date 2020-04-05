# Task https://github.com/KatekovAnton/exampleTasks/blob/master/Bivalued/task.md
# For k-valued slices
# Time - O(n), Space - O(k)
class LRUCache:
    class Record:
        def __init__(self, key, val, next_=None, prev=None):
            self.next = next_
            self.prev = prev
            self.val = val
            self.key = key

    def __init__(self, max_records):
        if max_records < 1:
            raise "Are you dumb?"
        self._head = None
        self._tail = None
        self._cache = dict()
        self.max_records = max_records


    def _add_to_tail(self, key, val):
        if not self._tail and not self._head:
            self._head = LRUCache.Record(key, val)
            self._tail = self._head
            self._cache[key] = self._head
        else:
            self._tail.next = LRUCache.Record(key, val, prev=self._tail)
            self._tail = self._tail.next

    def _remove_key(self, key):
        to_remove = self._cache[key]
        if to_remove.prev:
            to_remove.prev.next = to_remove.next
        else:
            self._head = to_remove.next

        if to_remove.next:
            to_remove.next.prev = to_remove.prev
        else:
            self._tail = to_remove.prev
        del self._cache[key]

    def _remove_oldest(self):
        self._remove_key(self._head.key)

    def update(self, key, val) -> bool:
        """Updates existing key or adds non existed one
        Returns:
            bool: True if the key existed, False otherwise
        """
        if key in self._cache:
            self._remove_key(key)
            self._add_to_tail(key, val)
            self._cache[key] = self._tail
            return True
        else:
            if len(self._cache) == self.max_records:
                self._remove_oldest()
            self._add_to_tail(key, val)
            self._cache[key] = self._tail
            return False

    def newest_val(self):
        return self._tail.val

    def oldest_val(self):
        return self._head.val


def longest_slice(nums, slice_distinct_num):
    cache = LRUCache(slice_distinct_num)
    max_slice_size = 0
    curr_slice_size = 0

    for i, num in enumerate(nums):
        if (cache.update(num, i)):
            curr_slice_size += 1
        else:
            curr_slice_size = cache.newest_val() - cache.oldest_val() + 1
        if curr_slice_size > max_slice_size:
            max_slice_size = curr_slice_size

    return max_slice_size

def main():
    # Base tests
    assert(5 == longest_slice([4, 2, 2, 4, 2], 2))
    assert(3 == longest_slice([1, 2, 3, 2], 2))
    assert(4 == longest_slice([0, 5, 4, 4, 5, 12], 2))
    assert(2 == longest_slice([4, 4], 2))

    # K-valued slices
    assert(5 == longest_slice([0, 5, 4, 4, 5, 12], 3))
    assert(4 == longest_slice([0, 5, 4, 7, 7, 2, 12], 3))
    assert(4 == longest_slice([7, 7, 7, 7, 2, 7, 7], 1))
    assert(6 == longest_slice([1, 2, 3, 4, 5, 6, 3, 8, 9, 10, 11], 5))

    print("All passed")

if __name__ == '__main__':
    main()

