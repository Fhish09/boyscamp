# Boyscamp Main Menu - Character & Background

## Default Operator
**Name:** Fhish  
**Title:** Lone Wolf / Shadow Step  
**Style:** Tactical, dark hoodie + vest look (from the reference image you provided earlier)

## Scripts Added
- `MainMenuCharacterDisplay.cs` → Handles name, title, portrait and subtle idle sway
- `OperatorBackgroundController.cs` → Manages background layers + slow camera drift

## Recommended Setup in Unity
1. Under Background create:
   - MainBackground (dark environment)
   - CharacterLayer (Fhish full body or portrait)
   - WeaponLayer (optional gun showcase)
   - Vignette

2. Attach OperatorBackgroundController to the Background object
3. Attach MainMenuCharacterDisplay to a UI panel that shows name + title

The character will gently sway and the camera will slowly drift for a premium feel.
