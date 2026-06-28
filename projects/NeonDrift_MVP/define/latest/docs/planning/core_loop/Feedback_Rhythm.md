# Core Loop Card: Feedback Rhythm

## 繁體中文

### 回饋節奏
- 即時回饋：button highlight、vehicle movement、trail brightness、score_delta_reason 或 pulse_delta_reason 必須在 0.1 秒內可見或可讀。
- 中期回饋：每 10 到 15 秒至少一次 combo milestone、speed line boost、lane flash、danger warning、near-miss cue 或短 SFX/haptic。
- 長期回饋：Best score、combo peak、retry count、session improvement 只作 MVP 輕量進度，不引入登入、商城或長期任務。

### 事件回饋
- Start、drift、boost pickup、near miss、hit hazard、pulse warning、game-over、Retry 都要有 VFX/SFX/haptic 或 reduced-motion fallback。
- Sound on 至少要有 UI click 與 gameplay cue；若 sound off，畫面仍需用 VFX/HUD 表達同一事件。

### 不可接受狀態
- 10 秒以上沒有新 threat、collectible、score reason、pulse reason 或 input feedback，QA 應判定 gameplay lifeless。
- 不可只用文字說明玩法；玩家必須從畫面理解危險、獎勵、操作與失敗。

## English

### Feedback Rhythm
- Immediate feedback: button highlight, vehicle movement, trail brightness, score_delta_reason, or pulse_delta_reason appears within 0.1 seconds.
- Mid feedback: every 10 to 15 seconds needs combo milestone, speed line boost, lane flash, danger warning, near-miss cue, or short SFX/haptic.
- Long feedback: Best score, combo peak, retry count, and session improvement stay lightweight; no login, shop, or long mission in MVP.

### Event Feedback
- Start, drift, boost pickup, near miss, hit hazard, pulse warning, game-over, and Retry need VFX/SFX/haptic or reduced-motion fallback.
- Sound on must include UI click and gameplay cue; sound off still needs VFX/HUD for the same event.

### Invalid States
- More than 10 seconds without new threat, collectible, score reason, pulse reason, or input feedback fails as lifeless gameplay.
- Gameplay cannot rely only on explanatory text; the screen must communicate danger, reward, action, and failure.

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
