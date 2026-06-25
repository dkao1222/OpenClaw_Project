# Proposal Card: Game Screen Outline

## 繁體中文

### 遊戲畫面輪廓
- 直式畫面：top-left score/combo、top-right pulse/boost、Dynamic Island safe area、中央 dark track、cyan/magenta lane、bottom left/right controls。
### 畫面層次
- Screen Layers 至少包含 background、speed lines/parallax、track lane、vehicle/hazard/boost、HUD/modal；Start 後 overlay 消失並出現 gameplay objects。
### 可讀性邊界
- iPhone SE 上 HUD 必須可讀；effects 不得遮住 vehicle、hazard、boost、buttons、failure reason；QA video 不可呈現黑屏、純色或空場景。

## English

### Game Screen Outline
- Portrait screen: top-left score/combo, top-right pulse/boost, Dynamic Island safe area, central dark track, cyan/magenta lane, and bottom left/right controls.
### Screen Layers
- Screen Layers include background, speed lines/parallax, track lane, vehicle/hazard/boost, and HUD/modal; after Start the overlay disappears and gameplay objects appear.
### Readability Boundaries
- HUD must be readable on iPhone SE; effects cannot hide vehicle, hazard, boost, buttons, or failure reason; QA video cannot show black screen, flat color only, or empty scene.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
