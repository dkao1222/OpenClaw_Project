# Game Systems Overview

Document contract: this file records only the current stage decision surface for the next planning owner. Do not copy full prior documents, and keep each subsection compact.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md; use GAMEPLAY_DEPTH.md and VISUAL_RICHNESS.md when this file affects gameplay or presentation.
- Gameplay depth score: target 3 when this file owns game systems, GDD, mechanics, content, or production readiness; otherwise inherited from upstream planning.
- Gameplay depth evidence: short-session objective, player decision, risk/reward, combo, boost, wave/phase, hazard pattern, failure reason, HUD feedback, and QA acceptance must be explicit before development.
- Visual richness score: target 3 when this file owns visual direction, art/audio, feedback, GDD, or production readiness; otherwise inherited from upstream planning.
- Visual richness evidence: visual richness target, minimum polish bar, background layers, track materials, typography style, icon style, motion polish, particle/VFX budget, reduced motion fallback, and performance target must be explicit before development.
- Current-stage minimum: planning final requires gameplay depth 3+ and visual richness 3+.
- Blockers: fail the stage if depth/richness is described only as fun, polished, neon, or challenging without concrete rules, assets, event feedback, and acceptance criteria.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, SYSTEM_DESIGN_LAYERS.md, DESIGN_METHODS.md, SYSTEM_SPEC_TEMPLATE.md, VALIDATION_GATES.md when this file affects game systems.
- System purpose: every system must state player value, product value, and non-goals before spec review.
- 5W1H summary: What, Why, Who, Where, When, and How must be explicit for gameplay systems, content, activities, rewards, and GDD rules.
- Layer coverage: strategy, scope, structure, interaction, and presentation must be covered before development.
- Implementation handoff readiness: state, input, output, rule, dependency, feedback, edge case, config, and QA acceptance must be present.
- Risks or blockers: fail the stage if a system requires engineering to invent missing behavior.

## 繁體中文

required keywords: game, systems, overview

### 範圍
- 系統範圍鎖定七個 MVP 系統：Control System、Speed System、Hazard System、Content Objective System、Scoring System、Failure/Retry System、Feedback System；不加入帳號、多人、商店或長線任務。

### 決策
- 每個系統必須定義 input、state、rule、output、dependency：Control 讀取左右觸控並輸出 drift intent；Speed 依存活時間與 boost state 提升速度；Hazard 依速度調整生成密度；Content Objective 管理 wave objective、boost cell、combo chain、hazard pattern 與短局任務；Scoring 依 survival、near miss、combo、boost pickup 累積分數；Failure/Retry 依 collision/off-line state 進入結果畫面；Feedback 依 objective/scoring/failure event 觸發 HUD、SFX、haptics。

### 交接重點
- 驗收標準是開發者可逐一實作並測試六個系統：每個系統都有明確成功條件、失敗條件、跨系統依賴、可觀察 UI/HUD 輸出與 spec review 待細化項。

## English

required keywords: game, systems, overview

### Scope
- The MVP system scope is limited to seven systems: Control System, Speed System, Hazard System, Content Objective System, Scoring System, Failure/Retry System, and Feedback System; accounts, multiplayer, shop, and long-term quest systems are out of scope.

### Decisions
- Each system must define input, state, rule, output, and dependency: Control reads left/right touch and outputs drift intent; Speed increases from survival time and boost state; Hazard adjusts spawn density from speed; Content Objective manages wave objective, boost cell, combo chain, hazard pattern, and short-session missions; Scoring accumulates survival, near miss, combo, and boost pickup points; Failure/Retry enters results from collision/off-line state; Feedback triggers HUD, SFX, and haptics from objective/scoring/failure events.

### Handoff Notes
- Acceptance requires developers to implement and test the seven systems independently: each system has explicit success conditions, failure conditions, cross-system dependencies, observable UI/HUD output, and spec review items that still need detail.
