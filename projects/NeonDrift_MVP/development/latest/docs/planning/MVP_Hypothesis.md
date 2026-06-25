# MVP Hypothesis

## 繁體中文

### 假設索引
- 本文件只作為 hypothesis index；完整假設拆成 Risk_Hypotheses、Validation_Methods、Success_Metrics、Decision_Rules 四張 context cards。
- 下游不得只用「玩家會重玩」這種一句話做產品判斷；每個假設都必須有玩家價值、產品風險、可觀測證據、失敗訊號與回退規則，並保留 source_paths 給 spec review 追溯。

### 上下文卡片
- Risk_Hypotheses.md：鎖定 first-run clarity、visual richness、gameplay depth、retry motivation、rewarded ads timing 與 counter-signal。
- Validation_Methods.md：鎖定 QA video、runtime probe、iOS simulator、Start/Retry/left/right/hazard/boost evidence 與測試邊界。
- Success_Metrics.md：鎖定 0 failed、0 blocked、first-run duration、retry rate、D1 retention、frame pacing、nonblank screenshot 與門檻。
- Decision_Rules.md：鎖定 Pass/Fail、return to planning、return to development、Spec Review/Development hard gate 與 acceptance policy。

### 下游讀取規則
- Spec Review 必須逐卡檢查假設是否能被測；Development 只能實作已轉成 runtime evidence 或 QA acceptance 的假設。
- 若 QA 影片或 runtime probe 無法驗證假設，該假設不得宣稱 passed，也不得推進到 build/QA 成功狀態。

## English

### Hypothesis Index
- This file is only the hypothesis index. Full assumptions are split into Risk_Hypotheses, Validation_Methods, Success_Metrics, and Decision_Rules context cards.
- Downstream work must not rely on a one-line replay assumption; every hypothesis needs player value, product risk, observable evidence, failure signal, rollback rule, and source_paths for spec review traceability.

### Context Cards
- Risk_Hypotheses.md locks first-run clarity, visual richness, gameplay depth, retry motivation, rewarded ads timing, and counter-signal.
- Validation_Methods.md locks QA video, runtime probe, iOS simulator, Start/Retry/left-right/hazard/boost evidence, and test boundaries.
- Success_Metrics.md locks 0 failed, 0 blocked, first-run duration, retry rate, D1 retention, frame pacing, nonblank screenshot, and thresholds.
- Decision_Rules.md locks Pass/Fail, return to planning, return to development, Spec Review/Development hard gate, and acceptance policy.

### Downstream Read Policy
- Spec Review verifies each hypothesis card is testable; Development only implements hypotheses converted into runtime evidence or QA acceptance.
- If QA video or runtime probe cannot verify a hypothesis, it cannot be marked passed or used to advance build/QA success.

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
