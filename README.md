# C# Daily Practice 🚀

Goal: Learn something new in C# every day and commit daily to build discipline, confidence, and consistency.

---

## 📌 To-Do Programs

- [ ] Day 01 – Hello World
- [ ] Day 02 – Print Name and Age
- [ ] Day 03 – Add Two Numbers
- [ ] Day 04 – Check Even or Odd
- [ ] Day 05 – Find Largest of Two Numbers
- [ ] Day 06 – Simple Calculator (Add / Subtract)
- [ ] Day 07 – Check Leap Year
- [ ] Day 08 – Reverse a String
- [ ] Day 09 – Count Digits of a Number
- [ ] Day 10 – Sum of First N Numbers

---

## 📝 Progress Log

- Day 01: Started the challenge 🎯

(Add one line here every day)

---

## 🔧 .NET CLI Commands (Quick Reference)

### Create Solution & First Project (One Time)

```bash
dotnet new sln -n CSharpDailyPractice
dotnet new console -n Day01
dotnet sln add Day01/Day01.csproj
```

### Create Project for New Day

```bash
dotnet new console -n Day02
dotnet sln add Day02/Day02.csproj
```

---

### ▶️ Run a Project

```bash
dotnet run --project Day01
```

---

### 🏗 Build

Build current folder:
```bash
dotnet build
```

Build solution:
```bash
dotnet build CSharpDailyPractice.sln
```

---

### 🧹 Clean Build Files

```bash
dotnet clean
```

---

### 🔍 Check Installed .NET Version

```bash
dotnet --version
```

---

## 🔄 Git Commands (Daily Use)

Check status:
```bash
git status
```

Stage changes:
```bash
git add .
```

Commit:
```bash
git commit -m "Day 01 - Completed Hello World program"
```

Push to GitHub:
```bash
git push
```

---

## 🌱 Git Setup (One Time Only)

```bash
git init
git branch -M main
git remote add origin https://github.com/<your-username>/csharp-daily-practice.git
git push -u origin main
```

---

## 📌 Useful Git Commands (Occasional)

Undo last commit (keep changes):
```bash
git reset --soft HEAD~1
```

View commit history:
```bash
git log --oneline
```

Create a new branch:
```bash
git checkout -b experiments
```

Switch back to main:
```bash
git checkout main
```

---

## 🧠 Daily Workflow (Follow This Blindly)

```bash
dotnet new console -n DayXX
dotnet sln add DayXX/DayXX.csproj
dotnet run --project DayXX
git add .
git commit -m "Day XX - Program name"
git push
```

---

## ✅ Rules

- Commit every day (even tiny code)
- Difficulty does not matter
- Consistency matters more than perfection
- One commit per day is a win
