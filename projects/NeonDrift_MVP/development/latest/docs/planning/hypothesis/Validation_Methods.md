# Hypothesis Card: Validation Methods

## 繁體中文

### 驗證方法
- machine terms: validation, QA video, runtime probe, iOS simulator, evidence, test boundary。
- QA video：錄到 Start、first 10 seconds、left/right input、hazard、boost、failure、Retry、after-retry 3 秒，作為人類視覺判讀依據。
- runtime probe：輸出 run_state、score、pulse、current_lane、target_lane、hazard_count、boost_count、pickup_count、last_failure_reason、score_delta_reason、pulse_delta_reason。
- iOS simulator：確認 app 可安裝、啟動、非黑屏、safe area、按鍵可點、frame pacing 合理，且 screenshot/video 與 probe 一致。

### 證據來源
- 每個 hypothesis 至少需要一個 visual evidence、一個 runtime evidence、一個 acceptance statement；只有文字描述不算 validation。

### 測試邊界
- MVP 不驗證付費轉換、D1 retention 真實數據或正式廣告收益，只定義後續 instrumentation 與不破壞 first-run 的廣告位置。

## English

### Validation Methods
- QA video records Start, first 10 seconds, left/right input, hazard, boost, failure, Retry, and 3 seconds after retry for human visual review.
- Runtime probe exports run_state, score, pulse, current_lane, target_lane, hazard_count, boost_count, pickup_count, last_failure_reason, score_delta_reason, and pulse_delta_reason.
- iOS simulator verifies install, launch, nonblank screen, safe area, clickable buttons, reasonable frame pacing, and agreement between screenshot/video and probe.

### Evidence Sources
- Every hypothesis needs at least one visual evidence, one runtime evidence, and one acceptance statement; text description alone is not validation.

### Test Boundaries
- MVP does not validate paid conversion, real D1 retention, or production ad revenue; it defines instrumentation and ad placement that does not damage first-run learning.

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
