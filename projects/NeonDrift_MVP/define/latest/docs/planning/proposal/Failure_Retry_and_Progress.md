# Proposal Card: Failure, Retry, and Progress

## 繁體中文

### 失敗、重試與進度
- Failure reason 只允許 hit hazard、pulse depleted、out of lane，且每個 reason 要對應畫面事件、HUD 變化或 QA evidence。
### 失敗原因
- hit hazard 需 flash/SFX/haptic；pulse depleted 必須在 HUD 可見；out of lane 需要 warning cue 或 lane flash。
### 重試回流
- Retry 重置 score/run state，移除 overlay，恢復 background/track motion，3 秒內出現 hazard 或 boost；after-retry visual delta 必須明顯，Best score 是唯一 MVP 持久進度。

## English

### Failure, Retry, and Progress
- Failure reason values are hit hazard, pulse depleted, and out of lane, each tied to screen event, HUD change, or QA evidence.
### Failure Reasons
- hit hazard needs flash/SFX/haptic; pulse depleted must be visible in HUD; out of lane needs warning cue or lane flash.
### Retry Return
- Retry resets score/run state, removes overlay, resumes background/track motion, and spawns hazard or boost within 3 seconds; after-retry visual delta must be obvious, and Best score is the only MVP persistent progress.

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
