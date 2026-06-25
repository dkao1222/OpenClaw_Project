# Proposal Card: High Concept

## 繁體中文

### 高概念
- NeonDrift MVP 是 iOS-first、單手操作的 neon drift dodging game；玩家用 left/right drift 在垂直 neon track 內切換安全線，避開 magenta hazard、收集 cyan/yellow boost、維持 combo 與 pulse。
- 這張卡的責任是鎖定遊戲輪廓，而不是替後續設計補完整 GDD；後續 stage 必須沿用這裡的 player promise、core feeling、主要物件與 failure logic。

### 玩家承諾
- 玩家在 30 到 90 秒內要完成一輪可理解、可失敗、可學習、可立即 retry 的 neon skill run；每次失敗都要讓玩家知道是 hit hazard、pulse depleted 或 out of lane。
- 玩家看到的不是抽象分數累加，而是 vehicle 位置、track light、hazard preview、boost pickup、combo/pulse HUD 同時回應 left/right decision。

### 核心體感
- Core feeling 是 read danger -> choose left/right drift -> vehicle/trail response -> score/combo/pulse change -> denser hazard wave。只有 passive score tick、空背景、無物件移動或不需操作也能得分都不合格。
- Input 必須有立即感：tap left/right 後 button highlight、vehicle lateral movement、trail color shift、small screen shake 或 haptic cue 至少要有兩項可見/可感知 feedback。

### 下游取用規則
- Stage 03-05 若需要定義 UX、mechanics、level pacing，必須先讀這張卡再讀 Primary Objects and Rules；不得把遊戲改成一般 racing、runner 或 idle score game。
- QA 需要用錄影證明 Start 後 10 秒內玩家能理解 left/right drift 的目的，並能看到 hazard、boost、score/combo/pulse 至少三種狀態變化。

## English

### High Concept
- NeonDrift MVP is an iOS-first, one-handed neon drift dodging game where the player uses left/right drift inside a vertical neon track to avoid magenta hazards, collect cyan/yellow boosts, and maintain combo and pulse.
- This card locks the game outline; later stages must preserve the player promise, core feeling, primary objects, and failure logic.

### Player Promise
- A 30 to 90 second neon skill run must be readable, failable, learnable, and instantly retryable. Every failure must explain hit hazard, pulse depleted, or out of lane.

### Core Feeling
- Core feeling is read danger -> choose left/right drift -> vehicle/trail response -> score/combo/pulse change -> denser hazard wave. Passive scoring, empty background, static objects, or no-skill scoring are invalid.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Product Experience Alignment

- Product experience cards read: product_experience/ROUTING.md, PRODUCT_EXPERIENCE_RUBRIC.md, FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md.
- First-run clarity evidence: objective, controlled object, danger, next action, success signal, failure reason, and retry recovery must be understandable from screen/video evidence.
- Feedback/game feel evidence: important input, score, collision, near miss, boost, failure, pause, and retry events must include visible/audio/haptic feedback expectations.
- Human visual QA: automated checks do not pass the product if screenshots/video remain unreadable, visually inert, confusing, or lack clear product value.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
