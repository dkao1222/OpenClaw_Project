# Proposal Card: High Concept

## 繁體中文

### 高概念
- NeonDrift MVP 是 iOS-first、單手操作的 neon drift dodging game；玩家用 left/right drift 在垂直 neon track 切換安全線，避開 hazard、收集 boost、維持 combo 與 pulse。
### 玩家承諾
- 玩家承諾是 30 到 90 秒內完成一輪可理解、可失敗、可學習、可立即 retry 的 neon skill run。
### 核心體感
- Core feeling 是 read danger -> left/right drift -> vehicle/trail response -> score/combo/pulse change -> denser hazard wave；passive score tick 不合格。

## English

### High Concept
- NeonDrift MVP is an iOS-first, one-handed neon drift dodging game; the player uses left/right drift on a vertical neon track to avoid hazards, collect boost, and maintain combo and pulse.
### Player Promise
- The promise is a 30 to 90 second neon skill run that is readable, failable, learnable, and instantly retryable.
### Core Feeling
- Core Feeling is read danger -> left/right drift -> vehicle/trail response -> score/combo/pulse change -> denser hazard wave; passive score tick is invalid.

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
