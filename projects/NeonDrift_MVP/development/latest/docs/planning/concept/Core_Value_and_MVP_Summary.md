# Concept Card: Core Value and MVP Summary

## 繁體中文

### 核心價值
- 價值 1：單手左右 drift 產生可見車體位移、軌跡變化、音效或 haptic，不能只有按鈕變色。
- 價值 2：hazard、boost、combo、pulse 形成短局風險取捨；玩家能理解為什麼分數增加、為什麼失敗、為什麼值得重試。
- 價值 3：霓虹街機畫面有背景層、賽道、玩家載具、敵人/障礙、收集物、特效與 HUD，不可退化成純色背景加方塊。

### MVP 摘要
- 必含：主選單、Start、Settings/Sound、Best Score、遊戲 HUD、left/right touch zones、pause、hazard wave、boost cell、score/combo/pulse、failure reason、Retry。
- 必含證據：runtime probe、iOS simulator screenshot/video、Start/Retry/left/right/hazard/boost/score state delta、safe-area check。

### 範圍邊界
- 不含：多人、帳號、雲端同步、商城、正式廣告收益調參、大型車輛收藏、長篇劇情。
- 廣告只作為 post-failure rewarded revive/bonus 的未來接口；第一輪 Start 與教學不可被廣告阻斷。

## English

### Core Value
- Value 1: one-handed left/right drift creates visible vehicle movement, trail change, sound, or haptic; button color alone is not enough.
- Value 2: hazard, boost, combo, and pulse create short-session risk tradeoff; players understand why score increases, why they fail, and why retry is worth it.
- Value 3: neon arcade presentation includes background layers, track, player vehicle, enemies/hazards, collectibles, effects, and HUD; it cannot regress to flat background and blocks.

### MVP Summary
- Required: main menu, Start, Settings/Sound, Best Score, run HUD, left/right touch zones, pause, hazard wave, boost cell, score/combo/pulse, failure reason, and Retry.
- Required evidence: runtime probe, iOS simulator screenshot/video, Start/Retry/left-right/hazard/boost/score state delta, and safe-area check.

### Scope Boundary
- Excluded: multiplayer, accounts, cloud sync, shop, production ad tuning, large car collection, and long story.
- Ads remain a future post-failure rewarded revive/bonus interface; first Start and first-run learning must not be interrupted by ads.

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
