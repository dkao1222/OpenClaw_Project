# Proposal Card: Primary Objects and Rules

## 繁體中文

### 主要物件與規則
- Player vehicle：cyan hover block 或 compact ship，必須有 lane position、drift direction、trail state、collision state。left/right drift 不是裝飾，必須改變 lane 或 lateral velocity。
- Hazard：magenta obstacle，從 track 上方進入，需有 warning color/shape，碰撞後觸發 hit hazard failure 或扣 pulse；不得生成在玩家無法反應的位置。
- Boost cell：cyan/yellow collectible，給 pulse recovery、combo sustain 或 score bonus；位置應形成 risk/reward，而不是永遠安全或永遠必死。
- Track lane：中央 playable corridor，左右 light strip 標示邊界；out of lane 必須有 warning cue，不能玩家不知道原因就失敗。
- HUD：score、best、pulse、combo、pause、retry 必須有清楚狀態來源；score 不可只靠時間增加而沒有互動分數來源。

### 碰撞與分數
- Score sources：survival tick 只能是基礎分；clean drift、near miss、boost pickup、combo chain 必須至少實作兩項，讓玩家操作和分數有因果關係。
- Collision rules：vehicle hitbox 應小於視覺外框，hazard hitbox 不得超出可見圖形；first 10 seconds 不得出現 unavoidable hazard。
- Pulse rules：pulse 可隨時間下降，但必須透過 boost、clean drift 或 combo 回補/減緩；若只是不操作也必死，畫面必須提前提示。
- Runtime evidence：QA/runtime probe 需能讀到 score_delta_reason、last_collision_type、pickup_count、combo_count、pulse_delta_reason。

### 公平性限制
- 前 10 秒 hazard wave 要教會讀法，不能同時塞滿左右兩側；boost 不得生成在 hazard 後方造成必死引誘。
- Button touch area 必須覆蓋底部左右大區塊；iOS simulator mouse click 和 touch 都要可觸發同一套 input path。
- Failure overlay 不能遮住仍在運作的 gameplay objects 到不可讀；game over 後需要 freeze 或 dim background，讓玩家知道 run ended。

## English

### Primary Objects and Rules
- Required objects are player vehicle, hazard, boost cell, track lane, and HUD. Each needs state, visual identity, and a rule that connects input to outcome.

### Collision and Scoring
- Score must come from survival plus at least two skill-linked events: clean drift, near miss, boost pickup, or combo chain. Collision, pulse, and pickup reasons must be inspectable by QA/runtime probe.

### Fairness Limits
- No unavoidable first-10-second hazard, no guaranteed-death boost, no tiny touch targets, and no unexplained failure. Simulator click and touch must reach the same input path.

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
