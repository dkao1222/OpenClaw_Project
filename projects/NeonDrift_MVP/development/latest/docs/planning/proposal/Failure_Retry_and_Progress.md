# Proposal Card: Failure, Retry, and Progress

## 繁體中文

### 失敗、重試與進度
- Failure reason 只允許 hit hazard、pulse depleted、out of lane；每個 reason 都要對應畫面事件、HUD 變化、runtime field 和 QA evidence。
- Game over 不是單純顯示 retry button；必須說明 run 為什麼結束，顯示 final score、best score、retry CTA，並保持背景 dim/freeze 讓玩家理解前一輪結果。

### 失敗原因
- hit hazard：需要 collision flash、short shake、SFX/haptic cue，並將 last_failure_reason 設為 hit hazard。
- pulse depleted：HUD pulse 必須在失敗前可見下降或警示，失敗時顯示 pulse depleted，不得在玩家無可理解選擇時突然結束。
- out of lane：需要 lane border warning 或 vehicle drift over-limit feedback；如果 MVP 沒有 out-of-lane 物理，則不得亂用這個 reason。

### 重試回流
- Retry 必須重置 score、combo、pulse、hazard list、boost list、vehicle lane、run timer；Best score 只在新分數超越時更新。
- Retry 後 3 秒內要看到 overlay 離場、track/background motion 恢復、vehicle 回到起始 lane、hazard 或 boost 再次出現；after-retry visual delta 必須可由錄影判斷。
- Settings/Pause 不得破壞 retry state；pause resume 後 input、spawn、score、pulse 應恢復一致。

## English

### Failure, Retry, and Progress
- Allowed failure reasons are hit hazard, pulse depleted, and out of lane. Each must map to screen event, HUD change, runtime field, and QA evidence.

### Failure Reasons
- hit hazard needs flash/shake/cue; pulse depleted needs visible HUD warning; out of lane needs lane warning and must not be used if the MVP has no out-of-lane rule.

### Retry Return
- Retry resets run state and within 3 seconds shows overlay exit, restored motion, reset vehicle lane, and new hazard or boost. Best score is the MVP persistent progress.

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
