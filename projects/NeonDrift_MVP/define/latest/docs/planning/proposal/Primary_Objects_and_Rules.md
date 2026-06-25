# Proposal Card: Primary Objects and Rules

## 繁體中文

### 主要物件與規則
- Player vehicle 是 cyan hover block，left/right drift 改變 lane position、trail direction、HUD feedback。Hazard 是 magenta obstacle，Boost cell 是 cyan/yellow collectible，Track lane 以 light strip 標示 safe area，HUD 固定顯示 score/best/pulse/combo/pause/retry。
### 碰撞與分數
- Collision 需要 visible warning；score 來源為 survival tick、clean drift、boost pickup、near miss，且在 QA log/runtime probe 可讀。
### 公平性限制
- Fairness limits：前 10 秒不得生成不可躲 hazard，boost 不得在必死點，button touch area 不得太小，無輸入失敗要提示 left/right drift。

## English

### Primary Objects and Rules
- Player vehicle is cyan hover block; left/right drift changes lane position, trail direction, and HUD feedback. Hazard is magenta obstacle, Boost cell is cyan/yellow collectible, Track lane marks safe area with light strip, and HUD fixes score/best/pulse/combo/pause/retry.
### Collision and Scoring
- Collision needs visible warning; score sources are survival tick, clean drift, boost pickup, and near miss, readable in QA log/runtime probe.
### Fairness Limits
- Fairness limits: no unavoidable hazard in first 10 seconds, no guaranteed-death boost, no tiny button touch area, and no-input failure hints left/right drift.

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
