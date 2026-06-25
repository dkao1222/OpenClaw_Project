# Game Objective

## 繁體中文

### 玩家目標
- 玩家每一局的明確目標是在霓虹賽道中維持漂移路線、避開可見威脅、收集 boost cell，並把 combo 延長到下一段高分區；目標必須在開局 10 秒內透過畫面、文字與互動回饋被理解。
- 這不是單純存活倒數，而是「看見下一個風險 -> 做出左右輸入 -> 立刻看到車體、軌跡、分數與音效回應 -> 追求更高 combo」的短局技巧挑戰。

### 勝利與失敗
- MVP 的勝利狀態是完成一段 60 到 90 秒 run 或達成本局目標分數；成功畫面必須顯示 score、best、combo peak、miss count 與 retry/next action。
- 失敗狀態必須來自可理解原因，例如撞上 hazard、drift pulse 歸零、或離開安全車道；失敗畫面要指出原因，不能讓玩家覺得什麼都沒發生就輸了。

### 十秒可玩性
- 第 0 到 3 秒：Start 後車體、左右 lane boundary、第一個 boost cell、第一個 hazard preview 必須出現，玩家能看到自己正在前進。
- 第 4 到 10 秒：至少發生一次左右輸入回饋、一次 score 增加、一次威脅接近、一次可避開或可收集事件，畫面不能只有靜態背景與 HUD。

### 驗收條件
- QA 影片必須能看出玩家輸入會改變車體或路線狀態，score/pulse/combo 至少一項隨互動變化，敵人或障礙會接近並產生可判讀的決策壓力。
- 本文件長度目標為 900 到 1800 個非空白字元；低於目標代表目標不夠具體，高於目標則要拆到 Core Gameplay Loop 或 Gameplay Depth Target。

## English

### Player Objective
- In every run, the player goal is to hold a readable drift line, avoid visible threats, collect boost cells, and extend combo into the next scoring section; the goal must be understandable within the first 10 seconds through screen state, text, and feedback.
- This is not passive survival. The loop is: see the next risk, make a left/right input, immediately read vehicle, trail, score, and audio response, then chase a higher combo.

### Win and Fail State
- MVP win state means completing a 60 to 90 second run or reaching the run score target; the result screen must show score, best, combo peak, miss count, and retry/next action.
- Failure must come from an understandable cause such as hitting a hazard, losing drift pulse, or leaving the safe lane; the fail screen must name the cause so the player never feels the run ended without reason.

### First 10 Seconds
- Seconds 0 to 3: after Start, vehicle, left/right lane boundary, first boost cell, and first hazard preview must appear so the player can see forward motion.
- Seconds 4 to 10: at least one left/right input response, one score increase, one approaching threat, and one avoid/collect decision must happen; the screen cannot be only static background and HUD.

### Acceptance Criteria
- QA video must show player input changing vehicle or route state, score/pulse/combo changing with interaction, and enemy/hazard objects approaching to create readable decision pressure.
- This file targets 900 to 1800 non-whitespace characters; shorter means the objective is underspecified, longer means details must move to Core Gameplay Loop or Gameplay Depth Target.

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
