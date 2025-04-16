# Pomodoro Timer with Task Management

This is a Pomodoro timer application that helps you stay focused and manage tasks efficiently. The app is designed to follow the Pomodoro Technique, which consists of 25-minute work sessions followed by short and long breaks. It also includes a task management feature to keep track of your to-do list while working.

## Features

- **Pomodoro Timer:** A timer that alternates between work and break sessions.
  - Work sessions last 25 minutes.
  - Short breaks last 5 minutes, and long breaks (after every 4 Pomodoros) last 15 minutes.
- **Task Management:** Add, remove, and mark tasks as completed.
  - Tasks are saved persistently in a JSON file.
- **Dark Mode Support:** Toggle between light and dark themes.
- **Custom Sound:** Option to play a custom sound when a Pomodoro session ends (supports `.wav` files).
- **Pomodoro Progress:** Track the number of Pomodoros completed with a visual tomato icon 🍅.

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/teabitter/pomodoro-timer-app.git
   ```

2. Open the solution in Visual Studio.

3. Make sure you have the necessary dependencies, such as `Newtonsoft.Json` for JSON file handling.

4. Build and run the application.

## Usage

### Starting the Timer

1. Click the **Start** button to begin the Pomodoro timer.
2. The timer will alternate between work and break sessions. When a session ends, a custom sound will be played if configured.

### Managing Tasks

1. Add new tasks in the **Task Input** field.
2. Click **Add Task** to add the task to the list.
3. Mark tasks as completed by clicking **Done** next to the task.
4. Remove tasks from the list using the **Remove** button.

### Theme Toggle

- Enable **Dark Mode** by checking the dark mode checkbox.

### Saving Tasks

- Your tasks are automatically saved in a `tasks.json` file located in the application directory.

## File Structure

- **Form1.cs**: Main form containing the Pomodoro timer and task management functionality.
- **tasks.json**: The JSON file where tasks are saved.

## Technologies Used

- **C#** (.NET Framework)
- **Windows Forms**
- **Newtonsoft.Json** for JSON serialization

## Contributing

1. Fork the repository.
2. Create a new branch for your feature.
3. Make your changes and commit them.
4. Push your changes and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
