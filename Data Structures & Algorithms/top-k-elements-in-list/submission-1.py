class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        freq  = [[] for i in range(len(nums)+1)]

        # put the freq in the count dictionary
        for n in nums:
            count[n] = 1 + count.get(n, 0)

        # add the element n to the c count
        for n,c in count.items():
            freq[c].append(n)

        # return the list
        res = []
        for i in range(len(freq) - 1, 0, -1):
            for n in freq[i]:
                res.append(n)
                if (len(res) == k):
                    return res