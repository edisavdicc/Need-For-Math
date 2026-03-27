# 🏎️ Need For Math

**Need For Math** is a 2D racing game built in **Unity** where math skills determine your speed. Players answer fraction and percentage questions — correct answers accelerate the car, wrong answers slow it down. The game features both a single-player mode and a local co-op mode where two players share one keyboard.

---

## 🎬 Demo

[![Need For Math Demo](https://img.youtube.com/vi/bXFNkfOqO18/maxresdefault.jpg)](https://youtu.be/bXFNkfOqO18)

> Click the link to watch the demo on YouTube.

---

## 📸 Screenshots

<!-- Add your screenshots by creating a `screenshots/` folder in the repo root -->
<!-- Name them screenshot1.png, screenshot2.png, etc. and they will display here -->

<p align="center">
  <img src="Skärmbild 2026-03-27 040715.png" width="45%" alt="Main Menu"/>
  <img src="Skärmbild 2026-03-27 040837.png" width="45%" alt="Gameplay"/>
</p>
<p align="center">
  <img src="Skärmbild 2026-03-27 040847.png" width="45%" alt="Co-Op Mode"/>
  <img src="Skärmbild 2026-03-27 040854.png" width="45%" alt="Game Over / Leaderboard"/>
  <img src="Skärmbild 2026-03-27 040905.png" width="45%" alt="Game Over / Leaderboard"/>
</p>

---

## ✨ Features

### 🧮 Math-Driven Gameplay
- Answer multiple-choice questions covering fractions, decimals, percentages, and mixed numbers
- **Correct answer** → car speeds up (+15 velocity)
- **Wrong answer** → car slows down (-10 velocity)
- 8 questions per race in solo mode, 10 in co-op

### 🏁 Game Modes
- **Single Player** — race against the clock, answering questions solo
- **Co-Op** — two players share one keyboard, each controlling alternate questions:
  - Player 1 uses keys `1` `2` `3` `4`
  - Player 2 uses keys `7` `8` `9` `0`

### 🏪 Car Shop
- Earn points by answering correctly
- Spend points in the in-game shop to unlock new car skins
- 4 cars available at different price tiers (5 / 10 / 20 / 25 points)

### ⏱️ Timer & Leaderboard
- Live timer tracks your race time (hours:minutes:seconds)
- End screen shows your final score and time
- Leaderboard screen to compare results

### 🔊 Audio
- Background music (Vivaldi — *Winter*, Op. 8)
- Toggle sound on/off with a persistent setting (saved via `PlayerPrefs`)
- Music carries across scene loads with `DontDestroyOnLoad`

### 🎥 Camera
- Camera follows the car in real time using world-to-screen projection

---

## 🗂️ Project Structure

```
Need-For-Math/
├── Assets/
│   ├── Scenes/
│   │   ├── MainMenu.unity          # Start screen with Solo / Co-Op buttons
│   │   └── SampleScene.unity       # Main race scene
│   ├── Scripts/
│   │   ├── GameManager.cs          # Solo mode: questions, scoring, car speed
│   │   ├── CoOpScript.cs           # Co-op mode: split keyboard input + questions
│   │   ├── MainMenu.cs             # Scene loading and audio persistence
│   │   ├── ShopManager.cs          # Car shop logic and coin management
│   │   ├── GameOverScreen.cs       # End screen, score display, leaderboard toggle
│   │   ├── Timer.cs                # Live race timer
│   │   ├── CameraFollow.cs         # UI element tracking the car position
│   │   ├── MusicPlayer.cs          # Background music playback and volume
│   │   ├── SoundManager.cs         # Mute/unmute toggle with PlayerPrefs save
│   │   ├── MovingCar.cs            # Rigidbody velocity controller
│   │   └── ButtonInfo.cs           # Shop button item ID helper
│   ├── Ikoner/                     # Sprites, backgrounds, car images, icons
│   └── Fonts/                      # Roboto font family + Hemi Head display font
└── Packages/
```

---

## 🛠️ Technology Stack

| Component | Technology |
|---|---|
| Engine | Unity |
| Language | C# |
| UI | Unity UI (uGUI) + TextMeshPro |
| Physics | Unity Rigidbody (3D) |
| Audio | Unity AudioSource / AudioListener |
| Persistence | Unity PlayerPrefs |

---

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) with **Unity 2020.3 LTS** or later installed

### Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/Need-For-Math.git
   ```
2. Open **Unity Hub** → click **Open** → select the `Need-For-Math` folder
3. Open the `Assets/Scenes/MainMenu.unity` scene
4. Press **Play** in the Unity Editor

### Build for Desktop

1. Go to **File → Build Settings**
2. Select your target platform (Windows / macOS / Linux)
3. Click **Build and Run**

---

## 🕹️ How to Play

1. From the **Main Menu**, choose **Solo** or **Co-Op**
2. Answer the math question displayed on screen by clicking one of the four answer buttons
3. Each correct answer accelerates your car — wrong answers slow it down
4. Reach the finish line as fast as possible
5. On the **End Screen**, view your score and time, or open the **Leaderboard**
6. Visit the **Shop** mid-game to spend earned points on a new car skin

### Co-Op Controls

| Player | Buttons |
|---|---|
| Player 1 (odd questions) | `1` `2` `3` `4` |
| Player 2 (even questions) | `7` `8` `9` `0` |

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 📬 Contact

**Edis Avdic** – edis_123@live.se 
GitHub: [github.com/YOUR_USERNAME](https://github.com/edisavdicc)
