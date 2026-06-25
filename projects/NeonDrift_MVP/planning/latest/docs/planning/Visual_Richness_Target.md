# Visual Richness Target

## 繁體中文

### 視覺華麗度目標
- NeonDrift 的畫面目標是 mobile neon arcade，而不是純色背景加幾何方塊；至少要有賽道、玩家載具、敵人/障礙、收集物、動態背景與 HUD 層次。
- 華麗度不等於雜亂：每個發光、粒子、速度線、背景層都必須支援速度感、危險提示或操作回饋。

### 畫面層次
- 最少五層：深色遠景、移動速度線、可讀賽道、互動物件、HUD/彈窗；各層需有不同亮度與動態速度。
- 主色為深色背景搭配 cyan/magenta/yellow 重點，但敵人、boost、玩家軌跡與危險提示不能互相混淆。

### 特效與動態
- Start、drift、boost pickup、near miss、hit、game over、retry 都需要對應 VFX/SFX/haptic 事件；Sound on 必須能聽到至少 UI click 與 gameplay cue。
- 玩家車體與障礙要有持續運動，背景要有 parallax 或 scrolling cue，否則 QA 應判定畫面缺乏生命感。

### 可讀性限制
- 視覺效果不能遮住車體、hazard、left/right 按鈕、pause、retry 或 score；notch/Dynamic Island 區域不可覆蓋必要資訊。
- 每個 icon、按鈕、文字與 HUD 數字要在 iPhone SE 尺寸仍可讀，且顏色對比需能被影片判讀。

## English

### Visual Richness Target
- NeonDrift should read as mobile neon arcade, not a flat color background with geometric blocks; it needs track, player vehicle, enemy/hazard, collectible, moving background, and HUD layers.
- Richness does not mean clutter: every glow, particle, speed line, and background layer must support speed, danger cue, or input feedback.

### Screen Layers
- Minimum five layers: dark far background, moving speed lines, readable track, interactive objects, and HUD/modal; layers need different brightness and movement speed.
- Main palette is dark background with cyan/magenta/yellow accents, but enemy, boost, player trail, and danger cues must not be confused.

### Effects and Motion
- Start, drift, boost pickup, near miss, hit, game over, and retry need matching VFX/SFX/haptic events; Sound on must produce at least UI click and gameplay cue.
- Player vehicle and hazards need continuous motion, and the background needs parallax or scrolling cues; otherwise QA should mark the screen lifeless.

### Readability Limits
- Effects must not hide vehicle, hazard, left/right buttons, pause, retry, or score; notch/Dynamic Island areas must not cover required information.
- Every icon, button, label, and HUD number must remain readable on iPhone SE size and visually distinguishable in QA video.

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
