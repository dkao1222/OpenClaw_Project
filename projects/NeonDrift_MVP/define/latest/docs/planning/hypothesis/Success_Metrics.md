# Hypothesis Card: Success Metrics

## 繁體中文

### 成功指標
- QA 必須 0 failed / 0 blocked；若缺產品體驗、人類視覺感受、功能可玩性或錄影證據，不可算 passed。
- first-run duration 目標 30 秒以上；first-run 後 retry rate 目標 50% 以上；D1 retention 是後續軟指標，MVP 先定義事件欄位。
- 技術指標：iOS simulator 可安裝啟動、screenshot 非空白、frame pacing 無明顯卡死、runtime 無 fatal exception。

### 失敗指標
- Start button 無行為、retry 後黑屏、left/right 不改變車體、畫面沒有可動物件、無 hazard/boost、失敗原因不明，都屬 hard fail。
- 只靠 score 自動增加、pulse 自動歸零或文字提示解釋玩法，不算可玩性通過。

### 門檻
- 所有 hard gates 通過後才可進 Spec Review/Development；任何 human visual QA gate fail 都要回到對應 planning/spec/development 文件修正。

## English

### Success Metrics
- QA requires 0 failed / 0 blocked; without product experience, human visual feel, functional playability, and recording evidence, it cannot pass.
- First-run duration target is 30+ seconds; post-first-run retry rate target is 50%+; D1 retention is a later soft metric and MVP only defines event fields.
- Technical metrics: iOS simulator installs and launches, screenshot is nonblank, frame pacing has no obvious freeze, and runtime has no fatal exception.

### Failure Metrics
- Start has no action, retry black screen, left/right does not move vehicle, no moving objects, no hazard/boost, or unclear failure reason are hard fails.
- Auto score, passive pulse depletion, or text-only gameplay explanation does not pass playability.

### Thresholds
- All hard gates must pass before Spec Review/Development; any human visual QA failure returns to the matching planning/spec/development document.

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
