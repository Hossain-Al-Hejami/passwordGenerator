# Password Generator

A simple password generator built with C# and .NET.

I created this project to practise C# programming and learn how to generate random passwords using `System.Security.Cryptography`.

## Features

- Generate random passwords with a custom length
- Choose between uppercase and lowercase letters
- Include numbers and special characters
- Generate passwords using `RandomNumberGenerator`
- Simple console-based interface

## Technologies

- C#
- .NET
- System.Security.Cryptography

## Getting Started

Make sure you have the .NET SDK installed.

Clone the repository:

```bash
git clone https://github.com/Hossain-Al-Hejami/passwordGenerator.git
```

Navigate to the project folder:

```bash
cd passwordGenerator
```

Run the application:

```bash
dotnet run
```

## Example

```text
=== Secure Password Generator ===

Password length: 16
Include uppercase? (y/n): y
Include lowercase? (y/n): y
Include numbers? (y/n): y
Include special chars? (y/n): n

Generated password: Kp7mQ2xL9bT4nR6a
```

## What I Learned

While building this project, I practised:

- Working with methods and parameters
- Using loops and conditional statements
- Handling user input
- Working with strings
- Generating random values using `RandomNumberGenerator`

## Future Improvements

- Add input validation for password length
- Ensure each selected character type appears in the generated password
- Allow users to generate multiple passwords without restarting the application

---

Developed as a personal C# programming project.
