# Core Loop Card: Failure Return

## 繁體中文

### 失敗回流
- 允許 failure reason：hit hazard、pulse depleted、out of lane；每個 reason 必須有畫面事件、HUD 變化、last_failure_reason 與 QA video evidence。
- Game-over overlay 需顯示 Drift Lost、原因、score、best、retry；overlay 背景應 dim 或 freeze，但仍能看出上一輪失敗情境。

### 重試重置
- Retry 重置 score、combo、pulse、hazard list、boost list、vehicle lane、run timer、collision_state，Best score 只在超越時更新。
- Retry 後 3 秒內需看到 overlay 離場、track/background motion 恢復、vehicle 回到起始 lane、hazard 或 boost 再次出現。

### 視覺差異
- after-retry visual delta 是硬規則：game-over frame 與 retry 後 gameplay frame 必須在截圖和影片中明顯不同。
- 若失敗時玩家未輸入，overlay 應提示 left/right drift；不得只顯示泛用 Drift Lost 讓玩家不知道怎麼玩。

## English

### Failure Return
- Allowed failure reasons: hit hazard, pulse depleted, and out of lane; each needs screen event, HUD change, last_failure_reason, and QA video evidence.
- Game-over overlay shows Drift Lost, cause, score, best, and retry; background should dim or freeze while preserving the failed context.

### Retry Reset
- Retry resets score, combo, pulse, hazard list, boost list, vehicle lane, run timer, and collision_state. Best score updates only when beaten.
- Within 3 seconds after Retry, overlay exits, track/background motion resumes, vehicle returns to start lane, and hazard or boost appears again.

### Visual Delta
- after-retry visual delta is a hard rule: game-over frame and post-retry gameplay frame must differ clearly in screenshot and video.
- If the player failed without input, overlay hints left/right drift instead of only showing generic Drift Lost.

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
