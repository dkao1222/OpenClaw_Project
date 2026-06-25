# Core Gameplay Loop

## 繁體中文

### 核心循環
- 單局循環為 Start -> 觀察 lane / hazard / boost -> 按住或點擊 left/right 漂移 -> 避開障礙或收集 boost -> combo/score/pulse 回饋 -> 風險提高 -> 成功結算或失敗 retry。
- 每 5 到 8 秒必須出現一個新的決策點，讓玩家感到自己正在主動控制節奏，而不是等待數字自然變化。

### 重複動作
- 基本動作是左右漂移、回正、搶 boost、躲 hazard、維持 combo；每個動作都需要可見車體偏移、軌跡變化、音效或 HUD 回饋。
- 玩家應能在 3 局內理解：提早轉向更安全，連續 clean drift 會增加 combo，貪 boost 會提高撞擊風險。

### 回饋節奏
- 即時回饋在 0.1 秒內出現：按鍵高亮、車體橫移、trail 顏色變化、score tick 或 pulse 變化。
- 中期回饋每 10 到 15 秒出現：combo milestone、speed line、lane flash、危險警示或短音效，避免畫面長時間無事件。

### 失敗後回流
- 失敗後必須顯示原因、分數、最佳分數、combo peak、明確 retry button；retry 後 3 秒內重新出現第一個互動事件。
- Retry 必須產生人眼可辨識的 after-retry visual delta：failure overlay 消失、score/timer/run state 重置、玩家或賽道重新動起來，且 retry 後截圖/影片需明顯不同於 game-over 畫面。
- 如果玩家失敗時沒有按鍵或移動，系統要以 tutorial hint 告知需要左右漂移，不能只顯示泛用 Drift Lost。

## English

### Core Loop
- The run loop is Start -> read lane/hazard/boost -> tap or hold left/right to drift -> dodge or collect -> receive combo/score/pulse feedback -> face higher risk -> finish or retry.
- A new decision point must appear every 5 to 8 seconds so the player feels active control rather than waiting for numbers to change.

### Repeatable Actions
- Basic actions are drift left/right, recover center, grab boost, avoid hazards, and maintain combo; every action needs visible vehicle movement, trail change, audio, or HUD feedback.
- Within 3 runs, the player should learn that earlier steering is safer, clean drift chains increase combo, and greedy boost collection raises collision risk.

### Feedback Rhythm
- Immediate feedback appears within 0.1 seconds: button highlight, vehicle lateral movement, trail color change, score tick, or pulse change.
- Medium feedback appears every 10 to 15 seconds: combo milestone, speed line, lane flash, danger warning, or short sound cue so the screen never stays eventless for long.

### Post-failure Return
- Failure must show cause, score, best score, combo peak, and a clear retry button; retry must return to the first interaction event within 3 seconds.
- Retry must create a human-visible after-retry visual delta: failure overlay removed, score/timer/run state reset, player or track motion resumes, and the after-retry screenshot/video differs clearly from the game-over frame.
- If the player fails without input or visible movement, the system must show a tutorial hint about left/right drifting instead of only a generic Drift Lost message.

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
