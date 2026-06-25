# Concept Card: Product Vision and Audience

## 繁體中文

### 產品願景
- NeonDrift MVP 是一款 iOS-first、短局、霓虹漂移反應遊戲；產品願景不是只讓分數自動上升，而是讓玩家在 10 秒內看懂自己正在駕駛、正在移動、正在做風險決策。
- 核心產品承諾是 fast entry、visible motion、clear danger、instant retry；每一局都要讓玩家感覺「我剛剛差一點可以更好」。

### 目標受眾
- 主要玩家是 13 到 35 歲喜歡 runner、reaction、arcade racing、one-thumb mobile games 的玩家，通常在通勤、排隊、休息時間玩 30 到 90 秒。
- 他們容忍簡單規則，但不容忍看不懂、按了沒反應、失敗原因不明、畫面像測試工具、retry 後沒有變化。

### 痛點與動機
- 痛點：手機快遊戲常見問題是開始太慢、畫面太空、按鍵太小、失敗太突然、廣告太早打斷。
- 動機：玩家想要立即操作、立即看到漂移軌跡、立即理解 hazard/boost/combo，並用 retry 追更高分。

## English

### Product Vision
- NeonDrift MVP is an iOS-first short-session neon drift reaction game. The vision is not auto-increasing score; it is making the player understand within 10 seconds that they are driving, moving, and making risk decisions.
- The product promise is fast entry, visible motion, clear danger, and instant retry; every run should make the player feel they almost did better.

### Target Audience
- Primary players are age 13 to 35 fans of runner, reaction, arcade racing, and one-thumb mobile games, usually playing 30 to 90 seconds during commute, waiting, or breaks.
- They accept simple rules but reject confusion, unresponsive input, unclear failure, test-tool visuals, and no post-retry change.

### Pain and Motivation
- Pain: mobile quick games often start slowly, show empty screens, use tiny buttons, fail suddenly, or interrupt too early with ads.
- Motivation: players want instant control, visible drift trail, readable hazard/boost/combo, and retry for a higher score.

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
