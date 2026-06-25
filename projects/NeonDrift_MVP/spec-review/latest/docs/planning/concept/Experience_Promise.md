# Concept Card: Experience Promise

## 繁體中文

### 體驗承諾
- 玩家按 Start 後 0 到 3 秒內要看到車體、賽道、背景動態、第一個 boost 或 hazard preview；畫面不能像黑屏或空場。
- 左右操作要讓玩家感覺到 drift，而不是 UI 按鈕測試；漂移方向、軌跡、score/pulse 變化要能被肉眼或錄影看到。

### 第一局感受
- 第一局應讓玩家理解三件事：左/右能改變路線、粉色/危險物要避開、亮色 boost 或 near miss 能提高分數/維持 pulse。
- 第一次失敗必須說明原因，例如 hit hazard、pulse depleted、out of lane；Retry 後 3 秒內要看到新一輪 gameplay 已恢復。

### 驗收證據
- QA video 需要錄到 Start、first 10 seconds、left/right input、hazard approaching、boost pickup、failure reason、Retry、after-retry visual delta。
- 若影片看起來像靜態 HUD、按鍵無行為、東西不動、玩家不知道目標，則即使 runtime probe pass 也不能算產品體驗 passed。

## English

### Experience Promise
- Within 0 to 3 seconds after Start, the player sees vehicle, track, background motion, and first boost or hazard preview; the screen cannot look black or empty.
- Left/right input must feel like drifting, not a UI button test; drift direction, trail, score/pulse changes must be visible to human eyes or recording.

### First Run Feeling
- The first run teaches three things: left/right changes route, pink/danger objects should be avoided, and bright boost or near miss raises score or maintains pulse.
- First failure must explain cause, such as hit hazard, pulse depleted, or out of lane; within 3 seconds after Retry, gameplay must visibly restart.

### Acceptance Evidence
- QA video must capture Start, first 10 seconds, left/right input, approaching hazard, boost pickup, failure reason, Retry, and after-retry visual delta.
- If video looks like static HUD, unresponsive buttons, unmoving objects, or unclear player goal, product experience cannot pass even when runtime probe passes.

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
