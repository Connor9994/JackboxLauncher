# 🎮 KaOs Jackbox Party Pack Collection Launcher

A sleek and intuitive Windows launcher application for managing and launching your entire Jackbox Party Pack collection from one centralized interface.

<img width="464" height="356" alt="image" src="https://github.com/user-attachments/assets/115a4acc-3fc8-4c25-b31c-2f90aa673dc6" />

## ✨ Features

- **Centralized Interface**: Launch any Jackbox Party Pack (1-11 + Naughty Pack) from one application
- **Visual Selection**: Dynamic cover art display for each party pack
- **Simple Navigation**: Clean, user-friendly interface with dropdown selection
- **Auto-Detection**: Automatically verifies game installation on startup

## 🚀 How to Use

1. **Select a Pack**: Choose your desired Jackbox Party Pack from the dropdown menu
2. **View Artwork**: See the corresponding cover art update automatically
3. **Get Info**: Click on the game artwork to visit the Steam store page
4. **Play!**: Click the "Play!" button to launch your selected game

## 🛠️ Installation & Setup

### Prerequisites
- Windows OS
- .NET Framework (version compatible with Windows Forms)
- Jackbox Party Packs installed in the following directory structure:

```
Jackbox Game Folder/
├── JackboxLauncher.exe
├── 1/
│   └── The Jackbox Party Pack.exe
├── 2/
│   └── The Jackbox Party Pack 2.exe
├── 3/
│   └── The Jackbox Party Pack 3.exe
├── ...
└── N/
    └── The Jackbox Naughty Pack.exe
```

## 🎯 Technical Details

**Platform**: Windows Forms (.NET)  
**Language**: C#  
**UI**: System.Windows.Forms  
**Dependencies**: None (uses native Windows processes)

## 🔧 Development

### Building from Source
1. Clone the repository
2. Open in Visual Studio
3. Build solution
4. Move "JackboxLauncher.exe" from Bin/Debug to your game folder
5. Double-check that the folder structure matches what is shown in "Prerequisites" above

## 🤝 Contributing

Contributions are welcome! Feel free to:
- Report bugs and issues
- Suggest new features
- Submit pull requests
- Improve documentation

## ⚠️ Important Notes

- This launcher requires "legitimate" copies of Jackbox Party Packs
- Games must be properly installed in the expected directory structure
- The application will exit if required games are not found
- Originally taken from ![Masquerade64's](https://github.com/Masquerade64/JackboxLauncher) GitHub (which I assume was either the original; or was pulled from the KaOsKrew website (https://kaoskrew.org)



