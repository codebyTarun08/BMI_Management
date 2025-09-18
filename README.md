# BMI Management Console Application (C#)

## 📌 Project Overview
This project is built using the **C# programming language** to demonstrate the logic of designing a console application for **BMI (Body Mass Index) management**.  
The application allows you to manage multiple persons, calculate their BMI, classify them into health categories, and compute average weight.

---

## 🏗️ Project Structure
The project contains **3 classes**:

1. **Person**
   - Members:
     - `name` (string)
     - `weight` (double)
     - `height` (double)

2. **BmiManagement**
   - Uses a **List of Person** objects.
   - Features:
     - Returns the status of each `Person` as **Overweight**, **Underweight**, or **Normal**.
     - Calculates and returns the **average weight** of all persons.

3. **Main Class (Program)**
   - Entry point of the application.
   - Handles user interaction (adding persons, viewing BMI results, checking average weight, etc.).

---

## ⚙️ Features
- Add persons with their **name, weight, and height**.
- Automatically calculate BMI for each person.
- Categorize individuals as:
  - **Underweight**
  - **Normal**
  - **Overweight**
- Compute and display the **average weight** of all persons.

---

## 🚀 How to Run
1. Clone or download this repository.
2. Open the project in **Visual Studio** or any C# IDE.
3. Build and run the project:
   ```sh
   dotnet run
