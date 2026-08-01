# Boyscamp Premium Main Menu Hierarchy

## Full Hierarchy Structure

```
MainMenu (Canvas)
├── Background
│   ├── OperatorRender
│   ├── ParallaxLayer
│   └── Vignette
├── TopBar
│   ├── AvatarButton
│   ├── RankIcon
│   ├── LevelXP
│   │   ├── LevelText
│   │   └── XPBar
│   └── CurrencyContainer
│       ├── SoftCurrencyPill
│       └── HardCurrencyPill
├── CenterContent
│   ├── BattlePassBanner
│   │   └── ShimmerEffect
│   └── ModeTabs
│       ├── BR_Tab
│       ├── Multiplayer_Tab
│       └── Ranked_Tab
├── DeployButton
│   ├── Glow
│   └── Label
└── BottomNav
    ├── LoadoutButton
    ├── StoreButton
    ├── SocialButton
    ├── EventsButton
    └── SettingsButton
```

## Important Notes
- Canvas should be set to Screen Space - Overlay
- Use Safe Area for TopBar and BottomNav
- DeployButton is the primary CTA (largest size)
- All buttons must respect 48x48 minimum tap target
