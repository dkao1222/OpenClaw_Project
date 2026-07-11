# MVP PRD

## 繁體中文

### 產品目標
- 交付一個可本機 build、可 QA 驗證、可在 Notion/Git 追蹤的 NeonDrift Unity MVP 基礎版本。

### 目標使用者
- 喜歡短局 arcade/reaction/racing 的手機玩家，需要單手可玩、立即回饋、快速 retry 與清楚 HUD。

### MVP 範圍
- 主選單、Start/Settings/Best Score、遊戲 HUD、左右觸控、pause、障礙、分數/boost/combo、失敗結果、retry、safe area、基本隱私/廣告準備、本機 iOS simulator build 與 QA evidence。

### 非目標
- 多人、帳號、雲端同步、商城、liveops、大型車輛/關卡內容、最終商店素材與正式廣告調參。

### 驗收條件
- Planning、spec review、development、build、QA 都必須產生可讀 Markdown/JSON/XML evidence，QA 需 0 failed / 0 blocked。
- iOS simulator app 可安裝與啟動，截圖非空白，runtime probe 顯示 Start/Pause/Retry/左右控制/safe area/frame pacing 通過。

## English

### Product Goal
- Deliver a NeonDrift Unity MVP foundation that can be locally built, QA-verified, and tracked through Notion/Git.

### Target User
- Mobile players who like short arcade/reaction/racing sessions and need one-handed play, immediate feedback, fast retry, and readable HUD.

### MVP Scope
- Main menu, Start/Settings/Best Score, run HUD, left/right touch, pause, hazards, score/boost/combo, failure result, retry, safe area, basic privacy/ads readiness, local iOS simulator build, and QA evidence.

### Non-goals
- Multiplayer, accounts, cloud sync, shop, liveops, large car/level content, final store assets, and production ad tuning.

### Acceptance Criteria
- Planning, spec review, development, build, and QA must produce readable Markdown/JSON/XML evidence, and QA must report 0 failed / 0 blocked.
- The iOS simulator app installs and launches, screenshot is nonblank, and runtime probe verifies Start/Pause/Retry/left-right controls/safe area/frame pacing.

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
