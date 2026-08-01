# Boyscamp - Android Build Guide

## Requirements
- Unity 2022.3 LTS or 2023.x
- Android Build Support module installed
- JDK and Android SDK (Unity usually installs these automatically)

## Steps to Build APK

1. Open the project in Unity Hub
2. Go to **File → Build Settings**
3. Select **Android** and click **Switch Platform**
4. Click **Player Settings**
5. Set these important values:
   - Company Name: Fhish09
   - Product Name: Boyscamp
   - Package Name: com.fhish09.boyscamp
   - Minimum API Level: Android 7.0 (API 24) or higher
   - Target API Level: Automatic (Highest Installed)
   - Scripting Backend: IL2CPP
   - Target Architectures: ARM64 (required for modern phones)

6. Go back to Build Settings
7. Click **Build** and choose a folder to save the APK

## After Building
- Transfer the .apk file to your phone
- Enable "Install from Unknown Sources" in phone settings
- Install and open Boyscamp

## Tips
- First build takes longer
- Always test on a real device
- Use Development Build only for testing
