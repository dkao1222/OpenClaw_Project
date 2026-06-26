# Platform Card: Build and QA Environment

## 繁體中文

### 建置環境
- Unity Editor 鎖定 6000.0.77f1；ProjectVersion、default build、batchmode build、development handoff 都必須保持一致。
- iOS-first build 使用本機 Unity batchmode 產出 iOS simulator target，再由 Xcode/simctl 安裝啟動；Project Name 可變，路徑必須從 Notion row/output folder 推導。

### QA 環境
- QA 必須包含 simulator launch、nonblank screenshot、runtime probe、video evidence、Start/Retry/Left/Right/Pause/Settings、hazard/boost/score/failure。
- 人類視覺感受是硬 gate：畫面看不懂、玩法不動、功能不可玩、沒有錄影證據，都不能算 passed。

### 交付限制
- Build/QA 只有在 pipeline request 允許時才能啟動；若需求寫明 Development only，不可建立或處理 Build/QA row。
- QA 通過後才可交付 simulator app、影片、報告、Git/Notion 文件；失敗則回 Development 修正，不可人工宣稱完成。

## English

### Build Environment
- Unity Editor is locked to 6000.0.77f1; ProjectVersion, default build, batchmode build, and development handoff must remain consistent.
- iOS-first build uses local Unity batchmode for iOS simulator target, then Xcode/simctl install and launch; Project Name may vary, so paths derive from Notion row/output folder.

### QA Environment
- QA includes simulator launch, nonblank screenshot, runtime probe, video evidence, Start/Retry/Left/Right/Pause/Settings, hazard/boost/score/failure.
- Human visual experience is a hard gate: confusing screen, static gameplay, unplayable functions, or missing video evidence cannot pass.

### Delivery Limits
- Build/QA start only when pipeline request allows it; if the request says Development only, Build/QA rows must not be created or processed.
- Only after QA passes may simulator app, video, report, Git/Notion docs be delivered; failures return to Development and cannot be manually declared done.

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
