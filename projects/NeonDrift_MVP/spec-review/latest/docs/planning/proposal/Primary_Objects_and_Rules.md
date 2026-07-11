# Proposal Card: Primary Objects and Rules

## 繁體中文

### 主要物件與規則
- Player vehicle：visual identity 是 cyan compact ship，不可只是未命名方塊；需要 nose/front direction、body glow、drift trail、hit flash。state fields 至少包含 current_lane、lateral_velocity、drift_direction、trail_state、is_invulnerable、collision_state。behavior rules：left/right input 在 0.1 秒內改變 lateral_velocity 或 target_lane，放開後回正，碰撞後進入 hit stun 或 failure。acceptance：QA 影片需看到 input 後車體位置與 trail 發生變化。
- Hazard：visual identity 是 magenta shard/barrier，不可與 boost/player 同形同色；需要 spawn_lane、approach_speed、warning_state、hitbox_scale、pattern_id、time_to_react。behavior rules：從 track 上方進入，至少提前 0.7 秒可見，first 10 seconds 不得生成 unavoidable hazard；碰撞後設定 last_collision_type=hazard 並觸發 hit hazard 或 pulse loss。
- Boost cell：visual identity 是 cyan/yellow energy cell，必須和 hazard 在形狀、色相、動態上可區分；state fields 包含 spawn_lane、value_type、pulse_restore、combo_extend、pickup_window。behavior rules：位置形成 risk/reward，不能永遠安全，也不能被 hazard 完全遮住；pickup 後要有 flash、score_delta_reason=boost_pickup、pickup_count 增加。
- Track lane：中央 playable corridor 必須明確標出 safe lane、lane border、track center、speed cue；state fields 包含 lane_count、safe_bounds、scroll_speed、warning_side。behavior rules：出界前先 lane flash 或 warning cue，out_of_lane failure 只能在明確規則存在時使用。
- HUD：score、best、pulse、combo、boost、pause、retry 都要有資料來源與更新條件。score 不可只有時間 tick；combo 必須來自 clean drift、near miss 或 boost pickup；pulse 必須顯示下降、警示、回補或扣減原因。

### 碰撞與分數
- Score formula：survival_tick 是基礎分，每 0.5 到 1 秒小幅增加；clean_drift、near_miss、boost_pickup、combo_chain 至少實作兩項 skill-linked score source，且每項需要 score_delta_reason。
- Collision formula：vehicle hitbox 應小於視覺外框 10-25%，hazard hitbox 不得超出可見圖形；collision 必須記錄 last_collision_type、last_failure_reason、collision_world_position、time_since_start。
- Pulse formula：pulse 可隨時間下降，但 boost、clean drift 或 combo 至少一項能回補或減緩；pulse_delta_reason 必須可讀，pulse depleted 前需要 visible warning。
- Runtime evidence：QA/runtime probe 必須能讀到 current_lane、target_lane、score_delta_reason、last_collision_type、pickup_count、combo_count、pulse_delta_reason、hazard_count、boost_count、last_failure_reason。缺少這些欄位時 spec/development 不得宣稱 gameplay verified。

### 公平性限制
- Spawn fairness：前 10 秒 hazard wave 要教會讀法，不能同時封死所有可走 lane；time_to_react 不得低於玩家可感知與操作門檻，boost 不得生成在 hazard 後方造成必死引誘。
- Input fairness：button touch area 必須覆蓋底部左右大區塊，iOS simulator mouse click、touch、keyboard fallback 需要進入同一套 input path；按鍵 feedback 不得只改 UI 顏色，必須改變 vehicle state。
- Failure fairness：failure overlay 不能遮住仍在運作的 gameplay objects 到不可讀；game over 後需要 freeze 或 dim background，顯示原因與 retry。無輸入失敗時要提示 left/right drift，不得只顯示泛用 Drift Lost。
- Acceptance：Spec Review 必須把上列 fields 轉成 implementation checklist；Development 必須在 RuntimeQaProbe 或同等 QA schema 中輸出；QA 必須用影片證明 Start、input、hazard、boost、collision/failure、retry 至少各一次。

## English

### Primary Objects and Rules
- Required objects are player vehicle, hazard, boost cell, track lane, and HUD. Each needs visual identity, state fields, behavior rules, numeric bounds, and acceptance evidence; abstract colored blocks are not enough.
- Player exposes current_lane, lateral_velocity, drift_direction, trail_state, and collision_state. Hazard exposes spawn_lane, approach_speed, warning_state, hitbox_scale, pattern_id, and time_to_react. Boost exposes spawn_lane, value_type, pulse_restore, combo_extend, and pickup_window.

### Collision and Scoring
- Score must include survival plus at least two skill-linked sources: clean_drift, near_miss, boost_pickup, or combo_chain. Runtime evidence must expose score_delta_reason, last_collision_type, pickup_count, combo_count, pulse_delta_reason, hazard_count, boost_count, and last_failure_reason.

### Fairness Limits
- No unavoidable first-10-second hazard, no guaranteed-death boost, no unexplained failure, no tiny touch targets, and no UI-only input feedback. QA video must prove Start, input, hazard, boost, failure/collision, and retry at least once.

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
