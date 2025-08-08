# File System Change Tracker

This is a simple C# console application that monitors real-time changes in a specified folder and logs those events.

---

## Features

- Watches for **created, changed, deleted, and renamed** events in the specified directory.
- Displays event details in red text on the console.
- Logs all events to a list and saves them to a file named `data.txt`.
- Allows the user to view all recorded events by pressing any key.
- Press `Q` to exit the program.

---

## How to Use

1. Run the application.
2. When prompted, enter the full path of the folder you want to monitor (e.g., `C:\Users\YourName\Documents`).
3. The program will start tracking changes in the specified folder.
4. Press any key to view all recorded events.
5. Press `Q` to quit the program.

---

## Requirements

- .NET 9.0
- Console access

---

## Notes

- The program continuously watches the folder and its subdirectories.
- All events are saved to `data.txt` in the application directory.
- Make sure you have read/write permissions for the folder and `data.txt` file.

---

## 👨‍💻 Author
**Ali Süleymanlı**
