// https://leetcode.com/problems/permutations
#include <vector>



void insert(std::vector<std::vector<int>> &result, const std::vector<int> &alreadyGenerated, const std::vector<int> &other)
{
    if (other.size() == 1) {
        result.push_back(alreadyGenerated);
        result[result.size() - 1].push_back(other[0]);
        return;
    }
    
    for (int i = 0; i < other.size(); i++) {
        std::vector<int> newAlreadyGenerated = alreadyGenerated;
        newAlreadyGenerated.push_back(other[i]);
        
        std::vector<int> newOther;
        if (i == 0) {
            newOther.insert(newOther.begin(), other.begin() + 1, other.end());
        }
        else if (i == other.size() - 1) {
            newOther.insert(newOther.begin(), other.begin(), other.end() - 1);
        }
        else {
            newOther.insert(newOther.begin(), other.begin(), other.begin() + i);
            newOther.insert(newOther.end(), other.begin() + i + 1, other.end());
        }
        
        
        insert(result, newAlreadyGenerated, newOther);
    }
    
}

std::vector<std::vector<int>> permute(std::vector<int>& nums)
{
    std::vector<std::vector<int>> result;
    insert(result, {}, nums);
    return result;
}



//// v2 

void insertV2(std::vector<std::vector<int>> &result, std::vector<int> &A, int index)
{
    for(int i = index; i < A.size(); i++) {
        std::swap(A[i], A[index]);
        insertV2(result, A, index + 1);
        if (index == A.size() - 1) {
            result.push_back(A);
        }
        std::swap(A[i], A[index]);
    }
}

std::vector<std::vector<int>> permuteV2(std::vector<int> &nums)
{
    std::vector<std::vector<int>> result;
    insertV2(result, nums, 0);
    return result;
}
