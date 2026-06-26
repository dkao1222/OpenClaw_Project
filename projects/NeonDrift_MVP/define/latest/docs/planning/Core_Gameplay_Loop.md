# Core Gameplay Loop

## 繁體中文

### 循環索引
- 本文件只作為 core loop index；完整內容拆成 Loop_Timeline、Player_Actions、Feedback_Rhythm、Failure_Return 四張 context cards。
- 下游 agent 不應只讀本索引就實作 gameplay；game-designer、spec review、development 必須按任務讀取對應卡片，避免把 Start、left/right、hazard、boost、combo、score、failure、retry 簡化成單句摘要。

### 上下文卡片
- Loop_Timeline.md：鎖定 0-3、4-7、8-10 秒事件、decision point、hazard wave、boost window、score/pulse 可見變化與 QA evidence。
- Player_Actions.md：鎖定 tap/hold/left/right、current_lane、target_lane、lateral_velocity、drift_direction、trail_state 與可接受操作結果。
- Feedback_Rhythm.md：鎖定 button highlight、vehicle movement、trail、score_delta_reason、pulse_delta_reason、VFX、SFX、haptic、reduced-motion fallback。
- Failure_Return.md：鎖定 hit hazard、pulse depleted、out of lane、last_failure_reason、Retry reset、Best score 與 after-retry visual delta。

### 下游讀取規則
- Game Director 先讀 Loop_Timeline 與 Player_Actions，再展開系統規則；UI/UX 先讀 Feedback_Rhythm 與 Failure_Return，再定義控制和 overlay。
- Spec Review 必須逐卡檢查 source_paths、runtime evidence、QA video acceptance；缺任一卡不可進入 Development。

## English

### Loop Index
- This file is the core loop index. Full detail is split into Loop_Timeline, Player_Actions, Feedback_Rhythm, and Failure_Return context cards.
- Downstream agents must not implement gameplay from this index alone; each task reads the relevant card so Start, left/right, hazard, boost, combo, score, failure, and retry are not reduced to a one-line summary.

### Context Cards
- Loop_Timeline.md locks 0-3, 4-7, 8-10 second events, decision point, hazard wave, boost window, score/pulse changes, and QA evidence.
- Player_Actions.md locks tap/hold/left/right, current_lane, target_lane, lateral_velocity, drift_direction, trail_state, and accepted input results.
- Feedback_Rhythm.md locks button highlight, vehicle movement, trail, score_delta_reason, pulse_delta_reason, VFX, SFX, haptic, and reduced-motion fallback.
- Failure_Return.md locks hit hazard, pulse depleted, out of lane, last_failure_reason, Retry reset, Best score, and after-retry visual delta.

### Downstream Read Policy
- Game Director reads Loop_Timeline and Player_Actions before expanding systems; UI/UX reads Feedback_Rhythm and Failure_Return before controls and overlays.
- Spec Review must verify source_paths, runtime evidence, and QA video acceptance card by card; missing cards block Development.

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
