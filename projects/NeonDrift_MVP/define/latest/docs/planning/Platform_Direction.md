# Platform Direction

## 繁體中文

### 平台索引
- 本文件只作為 platform direction index；裝置相容性、輸入/safe area、build/QA 環境拆成三張 context cards。
- iOS-first 是本 MVP 的執行焦點；多平台可保留路徑，但不可讓 Android/WebGL 擾亂 iOS simulator 驗收。

### 上下文卡片
- Device_Compatibility_Targets.md：鎖定 iOS 15+、iPhone SE 2/3、iPhone mini、iPhone 15/Pro、性能與不合格條件。
- Input_and_Safe_Area_Model.md：鎖定 left/right touch zones、tap/hold/release、safe area、HUD、hit target 與 simulator input path。
- Build_and_QA_Environment.md：鎖定 Unity 6000.0.77f1、本機 batchmode、iOS simulator、QA video/runtime probe 與 Build/QA 啟動限制。

### 下游讀取規則
- UI/UX 必讀 Input_and_Safe_Area_Model；Development 必讀 Build_and_QA_Environment；QA 必讀所有 platform cards。
- 若 Project Name 變動，任何 build/QA 路徑必須從 Notion row/output folder 推導，不可硬編 NeonDrift_MVP 之外的固定路徑。
- source_paths: docs/planning/platform/Device_Compatibility_Targets.md; docs/planning/platform/Input_and_Safe_Area_Model.md; docs/planning/platform/Build_and_QA_Environment.md

## English

### Platform Index
- This file is only the platform direction index. Device compatibility, input/safe area, and build/QA environment are split into three context cards.
- iOS-first is the execution focus for this MVP; multiplatform paths may remain, but Android/WebGL must not distract from iOS simulator acceptance.

### Context Cards
- Device_Compatibility_Targets.md locks iOS 15+, iPhone SE 2/3, iPhone mini, iPhone 15/Pro, performance, and failure conditions.
- Input_and_Safe_Area_Model.md locks left/right touch zones, tap/hold/release, safe area, HUD, hit target, and simulator input path.
- Build_and_QA_Environment.md locks Unity 6000.0.77f1, local batchmode, iOS simulator, QA video/runtime probe, and Build/QA start limits.

### Downstream Read Policy
- UI/UX must read Input_and_Safe_Area_Model; Development must read Build_and_QA_Environment; QA must read all platform cards.
- If Project Name changes, build/QA paths derive from Notion row/output folder and must not hard-code paths outside the active project.
- source_paths: docs/planning/platform/Device_Compatibility_Targets.md; docs/planning/platform/Input_and_Safe_Area_Model.md; docs/planning/platform/Build_and_QA_Environment.md

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
