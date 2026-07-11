# Core Loop Card: Player Actions

## 繁體中文

### 玩家動作
- Tap left/right：短漂移修正，0.1 秒內產生 button highlight、target_lane 變化、lateral_velocity 脈衝與 trail_state 方向變化。
- Hold left/right：持續 drift force，drift_direction 維持到 release；release 後 vehicle 平滑回正，不可瞬移或無回饋。
- Risk action：玩家為 boost 或 near miss 主動接近危險，成功時 pickup_count/combo_count 增加，失敗時 last_collision_type 或 last_failure_reason 可讀。

### 狀態變化
- 必備 runtime state：current_lane、target_lane、lateral_velocity、drift_direction、trail_state、collision_state、is_input_active。
- 每個玩家動作都要連到至少一個 visible state 與一個 data state；只有按鈕顏色變化不算有效 gameplay input。

### 可接受行為
- iOS simulator click、touch input、keyboard fallback 若存在，必須進入同一套 input path；QA 應能用錄影看到車體位置或軌跡改變。
- 不合格：left/right 無 vehicle delta、retry 後 input 失效、game-over overlay 下仍能誤觸 gameplay、button touch area 小到 iPhone SE 難以操作。

## English

### Player Actions
- Tap left/right creates a short correction within 0.1 seconds: button highlight, target_lane change, lateral_velocity pulse, and directional trail_state.
- Hold left/right sustains drift_force until release; release recenters smoothly without teleporting or losing feedback.
- Risk action means approaching danger for boost or near miss; success increments pickup_count/combo_count, while failure exposes last_collision_type or last_failure_reason.

### State Changes
- Required runtime state: current_lane, target_lane, lateral_velocity, drift_direction, trail_state, collision_state, and is_input_active.
- Every action must connect to at least one visible state and one data state; button color alone is not valid gameplay input.

### Acceptance
- iOS simulator click, touch input, and keyboard fallback enter the same input path when present; QA video must show vehicle position or trail changing.
- Invalid: left/right with no vehicle delta, input broken after retry, gameplay touch leaking under game-over overlay, or tiny touch areas on iPhone SE.

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
