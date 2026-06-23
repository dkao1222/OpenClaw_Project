# Scoring and Failure Spec

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

required keywords: scoring, and, failure, spec

### 範圍
- Scoring and Failure Spec 只定義分數來源、分數顯示、失敗原因、結果畫面與 retry 導線。

### 決策
- 分數與失敗必須使用玩家可理解的事件名稱，避免結果畫面只有抽象數字。

### 交接重點
- 驗收標準是玩家能從 failure screen 理解分數來源與下一局可改善的原因。

## English

required keywords: scoring, and, failure, spec

### Scope
- Scoring and Failure Spec defines only scoring sources, score display, failure reasons, result screen, and retry path.

### Decisions
- Scoring and failure must use player-readable event names instead of only abstract numbers on the result screen.

### Handoff Notes
- Acceptance requires players to understand score source and what to improve next from the failure screen.
