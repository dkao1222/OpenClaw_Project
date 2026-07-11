# Core Loop Card: Loop Timeline

## 繁體中文

### 循環時間線
- 0 到 3 秒：Start 後 menu overlay 離場，player vehicle 進入起始 lane，track/background motion 開始，第一個 hazard preview 或 boost cell 出現在上方可視區。
- 4 到 7 秒：玩家 tap/hold left/right 時，current_lane 或 target_lane 必須變化，trail_state 可見，score 或 pulse 至少一項因 input 產生變化。
- 8 到 10 秒：出現第一個 decision point，例如避開 magenta hazard 或冒險拾取 cyan/yellow boost；不得只有純背景、HUD、被動 score tick。

### 決策節點
- 每 5 到 8 秒至少一次 decision point，包含 threat/reward、可行 input、可讀 feedback、成功結果與失敗結果。
- hazard wave 不得封死所有 lane；boost window 必須形成風險取捨，而不是永遠安全或永遠必死。

### QA 證據
- QA video 必須看得到 Start 前、Start 後 3 秒、第一次 left/right、第一次 hazard/boost、第一次 score/pulse 因果變化。
- runtime evidence 需包含 run_state、score、pulse、hazard_count、boost_count、current_lane、target_lane、last_failure_reason。

## English

### Loop Timeline
- 0 to 3 seconds: after Start, menu overlay exits, player vehicle enters the start lane, track/background motion begins, and first hazard preview or boost cell appears.
- 4 to 7 seconds: tap/hold left/right changes current_lane or target_lane, trail_state is visible, and score or pulse changes for an input-related reason.
- 8 to 10 seconds: the first decision point appears, such as dodging a magenta hazard or risking a cyan/yellow boost; flat background, HUD-only play, or passive score tick is invalid.

### Decision Points
- Every 5 to 8 seconds needs a decision point with threat/reward, valid input, readable feedback, success result, and failure result.
- Hazard wave must not close every lane; boost window must create risk tradeoff instead of being always safe or always fatal.

### QA Evidence
- QA video must show before Start, 3 seconds after Start, first left/right input, first hazard/boost, and first causal score/pulse change.
- Runtime evidence includes run_state, score, pulse, hazard_count, boost_count, current_lane, target_lane, and last_failure_reason.

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
