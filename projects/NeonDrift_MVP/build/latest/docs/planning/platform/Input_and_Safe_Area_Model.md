# Platform Card: Input and Safe Area Model

## 繁體中文

### 輸入模型
- iOS MVP 使用左右大觸控區，支援 tap、hold、release；simulator mouse click、touch input 與 optional keyboard fallback 必須進同一套 input path。
- 每個輸入都要有 visible state 與 runtime state：button highlight、vehicle delta、target_lane、drift_direction、trail_state。

### 安全區
- HUD score/pulse/pause 不可被 notch/Dynamic Island/home indicator 擋住；game-over/retry modal 不可遮住 left/right 操作區造成誤觸。
- 直式畫面需要為 iPhone SE 留出底部按鍵高度，且 instruction text 不可與按鍵或 home indicator 重疊。

### 按鍵與 HUD
- Left/Right touch target 至少 88x64 pt 等效尺寸；Start/Retry/Settings 不小於 44 pt minimum hit target。
- HUD 必須清楚區分 score、pulse、combo、best；只顯示數字但不說明變化原因不足以支撐 QA。

## English

### Input Model
- iOS MVP uses large left/right touch zones supporting tap, hold, and release; simulator mouse click, touch input, and optional keyboard fallback must enter the same input path.
- Every input needs visible state and runtime state: button highlight, vehicle delta, target_lane, drift_direction, and trail_state.

### Safe Area
- HUD score/pulse/pause cannot be blocked by notch, Dynamic Island, or home indicator; game-over/retry modal cannot cover left/right zones in a way that causes accidental gameplay input.
- Portrait layout reserves bottom button height for iPhone SE, and instruction text must not overlap controls or home indicator.

### Controls and HUD
- Left/Right touch target is at least 88x64 pt equivalent; Start/Retry/Settings must meet a 44 pt minimum hit target.
- HUD clearly separates score, pulse, combo, and best; showing numbers without explaining state change is insufficient for QA.

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
