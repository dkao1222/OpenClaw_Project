# Planning Output Quality Bar

## 繁體中文

### 輸出長度規則
- 每個 planning 子文件必須聚焦單一目的；一般文件非空白字元低於 900 代表過短，高於 4200 代表過長，應拆成下一層規格文件。
- Game Objective 必須維持 900 到 1800 非空白字元，因為它是後續 game-director、spec review、development 與 QA 的最小契約。

### 內容具體度規則
- 每個文件都要回答：玩家看到什麼、玩家做什麼、系統如何回應、失敗如何產生、QA 如何驗證；不能只寫有趣、華麗、清楚、沉浸等抽象詞。
- 若出現 placeholder、泛用模板句、或中文英文內容相同，整個 stage 不合格。

### 下游取用規則
- Game Director 先讀 Game Objective、Core Gameplay Loop、Player Interaction Model，再讀 PRD；只有缺細節時才讀完整 proposal。
- Spec Review 必須逐條核對玩法深度、視覺華麗度、輸入回饋、音效、safe area、裝置相容性與 QA evidence，不可只審查文件是否存在。

## English

### Output Length Rule
- Every planning sub-document must focus on one purpose; below 900 non-whitespace characters is too thin, above 4200 is too large and should be split into the next specification layer.
- Game Objective must stay between 900 and 1800 non-whitespace characters because it is the smallest contract for game-director, spec review, development, and QA.

### Specificity Rule
- Every file must answer what the player sees, what the player does, how the system responds, how failure happens, and how QA verifies it; abstract words like fun, rich, clear, or immersive are not enough.
- If placeholder text, generic template content, or identical Chinese/English content appears, the whole stage fails.

### Downstream Usage Rule
- Game Director reads Game Objective, Core Gameplay Loop, and Player Interaction Model before PRD; the full proposal is opened only when details are missing.
- Spec Review must check gameplay depth, visual richness, input feedback, audio, safe area, device compatibility, and QA evidence line by line, not only whether files exist.

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
