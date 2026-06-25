# Hypothesis Card: Decision Rules

## 繁體中文

### 決策規則
- Pass：所有假設都有 visual evidence、runtime evidence、acceptance statement，且 QA video 顯示玩家能理解控制、危險、獎勵、失敗與 retry。
- Fail：任何核心假設只停留在摘要、無證據欄位、無人類可讀畫面、或 automation pass 但影片看不懂，必須 return to planning 或 return to development。
- Conditional：若玩法可玩但美術華麗度不足，回到 Visual_Richness_Target/Style_Frames；若功能不可玩，回到 Core Loop/Spec/Development。

### 回退條件
- return to planning：缺遊戲輪廓、缺玩法深度、缺視覺華麗度、缺產品體驗假設。
- return to development：規格明確但 build 未實作、runtime probe 缺欄位、按鍵無行為、retry state 未重置。
- return to QA：build 修正後需重新錄影，不可沿用舊證據。

### 下一階段輸入
- Spec Review 只可接受拆卡後的 hypothesis 與 core loop；Development 只可接受已轉成 runtime fields、QA evidence、hard gate acceptance 的項目。

## English

### Decision Rules
- Pass: every hypothesis has visual evidence, runtime evidence, acceptance statement, and QA video showing the player understands controls, danger, reward, failure, and retry.
- Fail: any core hypothesis that stays as summary, lacks evidence fields, lacks human-readable screen, or passes automation while video is confusing must return to planning or return to development.
- Conditional: playable but visually weak returns to Visual_Richness_Target/Style_Frames; functionally broken returns to Core Loop/Spec/Development.

### Rollback Conditions
- return to planning: missing game outline, gameplay depth, visual richness, or product experience hypothesis.
- return to development: spec is clear but build lacks implementation, runtime probe misses fields, buttons do nothing, or retry state fails to reset.
- return to QA: after build fixes, record new evidence instead of reusing old evidence.

### Next Stage Input
- Spec Review only accepts split hypothesis and core loop cards; Development only accepts items translated into runtime fields, QA evidence, and hard gate acceptance.

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
