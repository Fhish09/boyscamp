# Boyscamp Main Menu - Visual Setup Guide

## 1. Canvas Setup
- Create a Canvas
- Render Mode: Screen Space - Overlay
- UI Scale Mode: Scale With Screen Size
- Reference Resolution: 1080 x 1920 (Portrait)
- Match: 0.5

## 2. Color Palette (use these exact values)

### Primary Accent (Deploy button & selected tabs)
RGB: 255, 89, 26
Hex: #FF591A

### Secondary Accent (highlights)
RGB: 38, 179, 255
Hex: #26B3FF

### Background Dark
RGB: 12, 12, 18
Hex: #0C0C12

### Card / Panel Background
RGB: 22, 22, 30
Hex: #16161E

### Text Primary
RGB: 255, 255, 255

### Text Muted
RGB: 170, 170, 185

## 3. Recommended Sizes (1080x1920)

- TopBar height: 110px
- Avatar: 80x80
- XP Bar height: 8px
- Currency Pill height: 48px
- Battle Pass Banner height: 140px
- Mode Tabs height: 56px
- Deploy Button: 420 x 110
- Bottom Nav height: 100px
- Icon size in Bottom Nav: 42x42

## 4. Hierarchy Reminder

MainMenu (Canvas)
├── Background
│   ├── OperatorRender (RawImage or 3D)
│   ├── ParallaxLayer
│   └── Vignette (full screen Image, black, alpha 0.55)
├── TopBar
├── CenterContent
│   ├── BattlePassBanner
│   └── ModeTabs
├── DeployButton
└── BottomNav

## 5. Scripts to Attach

- Root MainMenu object → MainMenuManager + MainMenuEntrance + MainMenuStyler + SafeAreaHandler
- DeployButton → DeployButtonEffect + MainMenuButtonFeedback
- Every interactive button → MainMenuButtonFeedback
- BattlePassBanner → BattlePassBanner script
- ModeTabs parent → ModeTabSystem
- BottomNav → BottomNavController
- TopBar → PlayerDataDisplay

## 6. Quick Test
After wiring everything, press Play. You should see:
- Staggered fade-in
- Deploy button breathing glow
- Tabs changing color when clicked
- Bottom nav highlighting
