# Array Interview Problems 📚

A collection of common array/data structures interview problems with solutions in C#.

---

## 📋 Problem Index

| # | Category | Problem | Difficulty | Status |
|---|----------|---------|------------|--------|
| 1 | Two Pointer | Two Sum | Easy | ✅ Done |

---

## Problems

### 1. Two Sum
**Category:** Two Pointer / Hash Map  
**Difficulty:** Easy  
**Status:** ✅ Completed

#### Problem Statement
Given an array of integers and a target number, return the indices of the two numbers such that they add up to the target.

#### Example
```
Input:
nums = [2, 7, 11, 15]
target = 9

Output:
[0, 1]

Explanation:
nums[0] + nums[1] = 2 + 7 = 9
```

#### Approach
- Use a **Hash Map** to store numbers and their indices
- As we iterate through the array, calculate the complement needed
- Check if the complement exists in the hash map
- If found, return the indices; otherwise, add the current number to the map

#### Complexity Analysis
- **Time Complexity:** O(n) - Single pass through the array
- **Space Complexity:** O(n) - For the hash map

#### Implementation
See [Program.cs](./Program.cs)

---

## 📝 How to Add New Problems

When adding a new problem, follow this template:

```markdown
### X. Problem Name
**Category:** [Category/Technique]  
**Difficulty:** [Easy/Medium/Hard]  
**Status:** [✅ Completed / 🔄 In Progress / ⏳ TODO]

#### Problem Statement
[Describe the problem clearly with constraints if any]

#### Example
[Include input/output examples]

#### Approach
[Explain the algorithm and strategy]

#### Complexity Analysis
- **Time Complexity:** O(...)
- **Space Complexity:** O(...)

#### Implementation
See [Program.cs](./Program.cs) or create separate file for multiple problems
```

---

## 🗂️ Categories Used

- **Two Pointer** - Problems solved using two pointers approach
- **Hash Map** - Problems using hash maps for O(1) lookups
- **Sliding Window** - Problems using sliding window technique
- **Dynamic Programming** - DP-based problems
- **Sorting** - Sorting-based approaches

---

## 📈 Progress Tracker

- Total Problems: 1
- Completed: 1
- In Progress: 0
- TODO: 0
