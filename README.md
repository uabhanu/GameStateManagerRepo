# 🏛️ Modular Game Flow System (Singleton & State Pattern)

**Project Name:** GameStateManager | **Status:** Architectural Prototype | **Platform:** PC / WebGL

---

## 💡 Overview
This project is an architectural prototype demonstrating a robust, **decoupled system** for managing application states and system communication within a Unity project. It is designed to be highly extensible, scalable, and to eliminate tight coupling between core game systems.

This prototype serves as proof of proficiency in core C# object-oriented design and architectural patterns.

## 🧱 Core Architectural Concepts

This system is built upon three fundamental design patterns to ensure clean, professional code.

### 1. The Game Flow Manager (Singleton Pattern)
* **Purpose:** Ensures a single, persistent instance of the **`GameStateManager`** exists throughout the application lifecycle.
* **Benefit:** Provides a reliable, globally accessible entry point for state changes without the need for error-prone `FindObjectOfType<>()` calls.

### 2. State Management (State Pattern / FSM)
* **Purpose:** Defines the core game loop and cleanly separates the logic for each stage of the game.
* **Structure:** Utilises a parent class (`AbstractGameState`) and multiple concrete state classes (e.g., `MenuState`, `GameplayState`).
* **Benefit:** Allows for easy addition or modification of game states (e.g., adding a `CutsceneState` or `LoadingState`) without modifying the core `GameStateManager` class.

### 3. Decoupled Communication (Observer Pattern - Events)
* **Purpose:** Enables systems (like UI, Audio, Score) to react to game changes without direct references to the source that initiated the change.
* **Implementation (Future Branch):** Will use C# Events and Delegates (or Scriptable Objects) to create a **`GameEvents`** utility class.
* **Example:** When the `GameStateManager` transitions to `GameplayState`, it fires an `OnGameStarted` event. The `UIManager` simply **subscribes** to this event to show the HUD, keeping the code clean.

---

## ⚙️ Technical Stack
| Category | Detail | Purpose |
| :--- | :--- | :--- |
| **Engine** | Unity 2023+ | The primary development environment. |
| **Language** | C# (DOT NET Standard 2.1) | Used for clean, object-oriented pattern implementation. |
| **Architecture** | Singleton, State Machine (FSM), Observer | Ensures scalable, maintainable, and loosely coupled codebase. |
| **Input** | Unity New Input System | Modern, event-based input handling. |

### 📁 Project Structure (Key Scripts)

    Assets/
    ├── Scripts/
    │   ├── Managers/
    │   │   ├── GameStateManager.cs (Singleton & State Controller)
    │   ├── States/
    │   │   ├── AbstractGameState.cs (Base Class)
    │   │   ├── MenuState.cs
    │   │   ├── GameplayState.cs
    |   |   ├── GameOverState.cs
    │   ├── Utilities/
    |   |   ├── GameEvents.cs (Future: Handles Observer Pattern)
    ├── Scenes/
        ├── MainScene.unity (Minimal setup scene)


## 🗓️ Roadmap (Phase 1: Game Flow)
The goal is to complete the core flow and ensure every component is unit-testable.

| Status | Task | Feature Branch |
| :--- | :--- | :--- |
| ✅ | **Project Setup:** Repository and basic Unity file structure. | `main` |
| 🚧 | **Singleton & FSM Implementation:** Complete core state machine and manager. | `feature/implement-fsm-singleton` |
| ⬜ | **Observer Pattern:** Implement the `GameEvents` system using C# Events. | `feature/add-event-system` |
| ⬜ | **UI Integration:** Write simple UIManager classes that *subscribe* to events. | `feature/ui-integration-subscribers` |

---

## 🤝 Contribution & Contact
This is a portfolio project focused on learning and demonstrating professional techniques. Contributions and feedback are welcome!

* **Contact:** uabhanu@gmail.com
* **GitHub:** uabhánu

***
**Latest Commit:** 10th Nov 2025 | **Build:** Prototype Phase 1
