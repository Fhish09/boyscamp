# Boyscamp Premium Main Menu Setup Guide

## Files Added
- MainMenuUI.cs → Main controller
- MainMenuButtonFeedback.cs → Press/hover scale feedback
- DeployButtonEffect.cs → Breathing glow + shockwave
- MainMenuStyler.cs → Color and style system

## Recommended Hierarchy (repeat from previous)

MainMenu (Canvas)
├── Background
├── TopBar
├── CenterContent
├── DeployButton
└── BottomNav

## How to wire it
1. Attach MainMenuUI to the root MainMenu object
2. Attach MainMenuButtonFeedback to every interactive button
3. Attach DeployButtonEffect to the Deploy button
4. Attach MainMenuStyler to the root for colors

## Color Palette
- Primary Accent: Orange-Red (1, 0.35, 0.1)
- Secondary: Cyan
- Background: Very dark blue-black
