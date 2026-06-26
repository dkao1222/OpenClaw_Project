# One Page Game Concept

## 繁體中文

### 概念索引
- 本文件只作為 one-page concept index；完整產品願景、受眾、核心價值、體驗承諾拆成三張 context cards，避免把產品體驗壓成摘要。
- 下游 agent 必須依任務讀取對應卡片；只讀本文件不足以做 spec review 或 development。

### 上下文卡片
- Product_Vision_and_Audience.md：定義產品願景、目標受眾、痛點、動機與 first-run 期待。
- Core_Value_and_MVP_Summary.md：定義核心價值、MVP 必含功能、證據、非目標與廣告邊界。
- Experience_Promise.md：定義玩家第一局感受、Start 後畫面、左右輸入、失敗原因、Retry 後視覺差異與 QA video evidence。

### 下游讀取規則
- Product Planner 到 Game Director：先讀 Experience_Promise，再讀 Core_Value；Spec Review 必須逐卡核對 product experience 是否可測。
- Development 不可只依 one-page 摘要實作；Start、Left/Right、hazard、boost、failure、retry 都要追溯到 concept/proposal/core_loop cards。
- source_paths: docs/planning/concept/Product_Vision_and_Audience.md; docs/planning/concept/Core_Value_and_MVP_Summary.md; docs/planning/concept/Experience_Promise.md

## English

### Concept Index
- This file is only the one-page concept index. Product vision, audience, core value, and experience promise are split into three context cards so product experience is not compressed into a thin summary.
- Downstream agents must read the relevant cards for their task; this index alone is not enough for spec review or development.

### Context Cards
- Product_Vision_and_Audience.md defines product vision, target audience, pain, motivation, and first-run expectation.
- Core_Value_and_MVP_Summary.md defines core value, required MVP features, evidence, non-goals, and ad boundary.
- Experience_Promise.md defines first-run feeling, post-Start screen, left/right input, failure reason, post-Retry visual delta, and QA video evidence.

### Downstream Read Policy
- Product Planner to Game Director reads Experience_Promise first, then Core_Value; Spec Review verifies product experience card by card.
- Development must not implement from the one-page summary alone; Start, Left/Right, hazard, boost, failure, and retry trace to concept/proposal/core_loop cards.
- source_paths: docs/planning/concept/Product_Vision_and_Audience.md; docs/planning/concept/Core_Value_and_MVP_Summary.md; docs/planning/concept/Experience_Promise.md

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
