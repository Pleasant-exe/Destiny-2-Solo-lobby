# Destiny 2 Matchmaking Disable

A simple script that lets you disable matchmaking in Destiny 2. This tool is perfect for solo players who want to enjoy bounties and activities without interruptions. 

The tool operates by creating or removing firewall rules:
- **First run**: Sets up the firewall rules to disable matchmaking.
- **Subsequent runs**: Toggles matchmaking on or off.

You can choose between two versions of the tool:
1. A user-friendly **.exe application** with a graphical interface.
2. A **PowerShell script** for those who prefer a script-based approach.

---

## ⚠️ Heresy Update
Bungie occasionally updates the port numbers. The tool is updated to reflect these changes, but if you encounter issues, please [report them here](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/issues).

---

## Why Use This?

Enjoy Destiny 2 without the hassle of random players during solo activities like bounties or exploration. This tool allows you to focus and play at your own pace.

---

## D2Solo (Executable Version)

### How to Use
1. Download the `.exe` file from the [Releases page](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/releases).
2. Run the `.exe` **as Administrator**.
3. Select your desired option (Enable or Disable matchmaking).
4. **Important:** Disable the matchmaking block after every use to restore normal functionality.

![How to Use](https://mrpl.me/V12560b_rfn5.png)

---

## PowerShell Script Version

### ⚠️ Important Notes
- Only use this script while Destiny 2 is running.
- **Disable the firewall rules before shutting down Steam** to avoid issues launching Steam online.
- For stability, it’s recommended to run this script while in Orbit.

### How to Use
1. Download the PowerShell script from the [Releases page](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/releases).
2. Allow PowerShell to execute `.ps1` scripts:
   - Open PowerShell as Administrator.
   - Run the following commands:
     ```powershell
     Set-ExecutionPolicy RemoteSigned
     Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass
     ```
   - If prompted, type `A` and press Enter.
3. Right-click the script, select **Open With > Windows PowerShell**, and follow the prompts. 
   - If the screen appears blank or the script closes immediately, don’t worry—this is normal.

#### Visual References
- **Disabling Matchmaking**:  
  ![Disable Example](http://mrpl.me/P31047b_rfs8.png)
- **Enabling Matchmaking**:  
  ![Enable Example](http://mrpl.me/l21048b_rff8.png)

---

## Downloads

- Get the latest version: [Download here](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/releases)  
- **Note:** Thanks to various Reddit users for identifying the required port numbers.  

![Total Downloads](https://img.shields.io/github/downloads/MrPleasant-exe/Destiny-2-Solo-lobby/total?style=social)  
![Last Commit](https://img.shields.io/github/last-commit/MrPleasant-exe/Destiny-2-Solo-lobby/master)  

---

## License and Contributions

Feel free to use and modify this script. Contributions are welcome! If you encounter any issues or have suggestions for improvement, submit a pull request or open an issue on the [GitHub repository](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby).
