# Gameplay Depth Target

## 繁體中文

### 玩法深度目標
- MVP 核心至少要有三層短局深度：基礎躲避、boost 風險取捨、combo 維持；玩家每次操作都應影響安全、分數或下一個風險。
- 單局不能只有靜態障礙與分數累加；必須有可見節奏變化，例如 lane shift、hazard wave、boost window、near-miss reward。

### 系統與數值
- Pulse 是壓力資源，會因 clean drift 或 boost 回升，因碰撞、離開路線或長時間無操作下降；它不能隨機歸零。
- Score 來源需要拆分為 survival tick、clean drift bonus、boost pickup、near-miss bonus，讓 QA 和玩家能判讀分數為何變化。

### 關卡節奏
- 前 10 秒教基礎輸入，10 到 30 秒加入第一種 hazard，30 到 60 秒加入 boost 取捨與 combo 壓力，60 秒後提高 wave 密度。
- 每個節奏段要有可被截圖/影片辨識的視覺提示，避免玩家只看到同一張背景。

### 不可接受狀態
- 不可出現敵人不前進、畫面無可互動物件、retry 後不動、retry 後畫面與 game-over 幾乎相同、sound on 無聲、失敗原因不明、Start 後沒有 gameplay 事件等狀態。
- QA 若錄到 10 秒以上沒有新威脅、收集物、分數原因或操作回饋，整體應判定 fail，並回到 build/development 修正。

## English

### Gameplay Depth Target
- MVP needs at least three short-session depth layers: basic dodge, boost risk tradeoff, and combo maintenance; every player action should affect safety, score, or the next risk.
- A run cannot be only static obstacles and score ticking; visible pacing changes are required, such as lane shift, hazard wave, boost window, and near-miss reward.

### Systems and Tuning
- Pulse is a pressure resource that recovers through clean drift or boost and drops from collision, leaving route, or long inactivity; it must never randomly hit zero.
- Score sources must be split into survival tick, clean drift bonus, boost pickup, and near-miss bonus so QA and players can understand why score changes.

### Level Pacing
- First 10 seconds teach input, 10 to 30 seconds add the first hazard, 30 to 60 seconds add boost tradeoff and combo pressure, and after 60 seconds wave density rises.
- Each pacing segment needs screenshot/video-visible cues so the player never sees the same background state for the whole run.

### Unacceptable States
- Unacceptable states include enemies not approaching, no interactable object on screen, retry not moving, retry looking nearly identical to game-over, sound on with no sound, unclear fail cause, and no gameplay event after Start.
- If QA records more than 10 seconds without new threat, collectible, score reason, or input feedback, the whole stage should fail and return to build/development fixes.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
