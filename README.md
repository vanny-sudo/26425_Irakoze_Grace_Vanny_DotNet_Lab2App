<h1 align="center">Lab 2: Bicycle Rental and Mushroom Guess</h1>

<p align="center">
  A simple Windows Desktop App that calculates Bicycle Rental Costs<br>
  and Guesses which Mushroom you are Thinking Of.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/language-C%23-512bd4" alt="C#">
  <img src="https://img.shields.io/badge/app-Windows%20Forms-0078d4" alt="Windows Forms">
  <img src="https://img.shields.io/badge/IDE-Visual%20Studio-5c2d91" alt="Visual Studio">
</p>

---

## About This Project

This app is a Windows Forms Application, that people can use with clicks instead of typing commands.

| Part | What it does |
|---|---|
| **Login** | Lets a user enter the app with a username and a password |
| **Choose** | Lets a user pick the Bicycle or the Mushroom tool |
| **Bicycle Rental** | Works out how much a Bicycle Rental Costs |
| **Mushroom Guess** | Asks simple questions and names your Mushrooms |

---

## How to use our App

```
Login  ->  Choose  ->  Bicycle   (Back = Choose, Logout = Login)
                   ->  Mushroom  (Back = Choose, Logout = Login)
```

- **Back** takes you to the Choose screen.
- **Logout** takes you to the Login screen.

---

## Our App Key Steps to Follow

Follow these steps from the first screen to the last.

### Step 1: Log in

Type any **Username** and any **Password**, then click **Login**.

![Login screen](<img width="397" height="243" alt="01-login" src="https://github.com/user-attachments/assets/a0c4c92d-632a-47f0-a93c-e248a63477ee" />
)

This is a practice app, so there is no real account. The only rule is that both boxes must be filled in. If one is empty, you will see this message:

![Login error message](<img width="398" height="240" alt="02-login-error" src="https://github.com/user-attachments/assets/7d8b197e-1a45-4e44-9045-af7011561f8a" />
)

### Step 2: Choose what you want to do

After you log in, you will see the Choose screen. Click **Bicycle** to calculate a rental cost, or **Mushroom** to play the guessing game.

![Choose screen](<img width="395" height="240" alt="03-choose" src="https://github.com/user-attachments/assets/ec895636-cf45-402d-a26b-f6d1c6772a0c" />
)

### Step 3: Use the Bicycle Rental tool

1. Type the **starting hour** (a whole number from 0 to 23).
2. Type the **ending hour** (a whole number from 1 to 24).
3. Click **Calculate**.
4. Read your cost in the **Total** box.

![Bicycle screen](<img width="590" height="266" alt="04-bicycle" src="https://github.com/user-attachments/assets/9b7c3c56-e25e-41fc-9176-52dc9a3d50c5" />
)

Here is an example. If you rent from 8 to 10, the Total box shows `2000 RWF`.

![Bicycle result](<img width="587" height="262" alt="05-bicycle-result" src="https://github.com/user-attachments/assets/4d51bc43-3a6a-40fc-8919-8244b0d4b1e9" />
)

**How the price is worked out:** each hour of your rental has its own price, and the app adds them together.

| Hours of the day | Price per hour |
|---|---|
| 0h to 7h and 21h to 24h | 500 RWF |
| 7h to 14h and 19h to 21h | 1000 RWF |
| 14h to 19h | 1500 RWF |

**Try these:**

| Start | End | Total |
|---|---|---|
| 8 | 10 | 2000 RWF |
| 6 | 8 | 1500 RWF |
| 13 | 15 | 2500 RWF |
| 20 | 22 | 1500 RWF |
| 0 | 24 | 22000 RWF |

**If you make a mistake**, a message box tells you what to fix:

| What you did | Message you will see |
|---|---|
| Typed letters instead of a number | Please enter a valid whole number |
| Start hour is not between 0 and 23 | Invalid starting time. It must be between 0 and 23. |
| End hour is not between 1 and 24 | Invalid ending time. It must be between 1 and 24. |
| Start hour is the same as or later than the end hour | Starting time must be less than ending time. |

![Bicycle error message](<img width="590" height="260" alt="06-bicycle-error" src="https://github.com/user-attachments/assets/4e1f3977-3877-4937-b7e0-45edfc9eb2d3" />
)

### Step 4: Play the Mushroom Guess game

Think of one of these mushrooms: **Agaric Jaunissant, Amanite tue-mouche, Cepe de bordeaux, Coprin chevelu, Girolle** or **Pied bleu**.

The app asks you questions. Click **Yes** or **No** for each one.

![Mushroom question](<img width="458" height="277" alt="07-mushroom-question" src="https://github.com/user-attachments/assets/90f37904-20d8-423a-8d4b-6de8f305aa83" />
)

At the end, a message box tells you which mushroom you were thinking of. Then the game starts again, so you can play as many times as you like.

![Mushroom result](<img width="455" height="276" alt="08-mushroom-result" src="https://github.com/user-attachments/assets/649bddb8-6c5b-4f7b-bfb8-f661ff81932e" />
)

**Which answers lead to which mushroom:**

| Your answers, in order | Your mushroom |
|---|---|
| Ring: Yes, Forest: Yes | Amanite tue-mouche |
| Ring: Yes, Forest: No, Convex cap: Yes | Agaric Jaunissant |
| Ring: Yes, Forest: No, Convex cap: No | Coprin chevelu |
| Ring: No, Gills: No | Cepe de bordeaux |
| Ring: No, Gills: Yes, Convex cap: Yes | Pied bleu |
| Ring: No, Gills: Yes, Convex cap: No | Girolle |

### Step 5: Go back or log out

On the Bicycle and Mushroom screens you will find two buttons at the bottom:

- **Back** returns you to the Choose screen, so you can pick the other tool.
- **Logout** returns you to the Login screen, so another person can log in.

To close the app, click the **X** in the top-right corner of any window.

---

## How to Run It on Your Computer

**You need:** a Windows computer with [Visual Studio](https://visualstudio.microsoft.com/) and the **.NET desktop development** workload installed.

1. Download or clone this repository.
2. Open the file `Lab2App.slnx` in Visual Studio.
3. Press **F5** to start the app.
4. On the Login screen, type any username and password.

---

## Built With

- **C#**: the programming language
- **Windows Forms**: for the windows, buttons and text boxes
- **Visual Studio**: where I wrote and tested the app

---

## Author

**Irakoze Grace Vanny**

I wrote this README in simple words so that anyone can use the app, even without computer experience. If something is not clear, please reach out to me and I will make it better.

---

## Contact Me

I would be happy to hear from you. Feel free to reach out about this project, for feedback, or for a chat about technology.

| | |
|---|---|
|  **Email** | [vannygrace2020@gmail.com] |
|  **GitHub** | [@Vanny003](https://github.com/vanny-sudo) |
|  **Location** | Kigali, Rwanda |

<p align="center">Thank you for visiting My Project! </p>
