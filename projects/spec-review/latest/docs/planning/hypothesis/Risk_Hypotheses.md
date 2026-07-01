# Hypothesis Card: Risk Hypotheses

## 繁體中文

### 風險假設
- machine terms: hypothesis, risk, first-run, visual clarity, retry, monetization。
- first-run clarity：玩家能在 10 秒內從畫面理解控制、危險、獎勵與失敗原因；counter-signal 是黑屏、空場景、純 HUD、按 Start 後不知道怎麼玩。
- visual richness：neon arcade 畫面層次能提升產品價值；counter-signal 是背景、物件、特效長時間不變或只像幾何測試場。
- gameplay depth：hazard、boost、combo、pulse 的風險取捨能支撐重玩；counter-signal 是 passive scoring、無決策、無可理解失敗。
- retry motivation：失敗原因與 after-retry visual delta 會提高 retry 意願；counter-signal 是 retry 後畫面不動或與 game-over 幾乎相同。
- rewarded ads：未來廣告只適合放在失敗後自願 revive/bonus，不得阻斷 first-run learning 或第一輪 Start。

### 玩家價值
- 玩家價值來自可理解、可操作、可進步，而不是只看到分數增加；每個 assumption 都要映射到 visible evidence。

### 產品風險
- 最大 risk 是 QA/automation pass 但人類玩家看不懂；因此 hypothesis 必須連到 human visual QA、recording evidence、runtime probe 三者。

## English

### Risk Hypotheses
- first-run clarity: player understands control, danger, reward, and failure reason within 10 seconds; counter-signal is black screen, empty scene, HUD-only play, or confusion after Start.
- visual richness: neon arcade layers raise product value; counter-signal is static background, objects, and effects that look like a geometry test scene.
- gameplay depth: hazard, boost, combo, and pulse create replayable risk tradeoff; counter-signal is passive scoring, no decision, or unclear failure.
- retry motivation: failure reason and after-retry visual delta improve retry; counter-signal is retry not moving or looking identical to game-over.
- rewarded ads: future ads only fit voluntary post-failure revive/bonus and must not block first-run learning or first Start.

### Player Value
- Player value is readability, control, and improvement, not score increasing by itself; every assumption maps to visible evidence.

### Product Risk
- Main risk is automation passing while humans cannot understand the product; every hypothesis links to human visual QA, recording evidence, and runtime probe.

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
- Research capture cards read: research_capture/ROUTING.md, SOURCE_CARD_SCHEMA.md, VALIDATION_GATES.md, Research_Source_Cards.md, source_card_id, license_or_terms, usage_risk, and do_not_use_directly. External references may influence planning only through bounded source cards and license-risk records.
