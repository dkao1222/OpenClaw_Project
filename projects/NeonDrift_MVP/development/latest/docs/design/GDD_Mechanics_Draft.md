# GDD Mechanics Draft

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

required keywords: gdd, mechanics, draft

### 範圍
- 機制草案定義漂移、加速、boost cell 收集、combo chain、wave objective、hazard pattern、碰撞、分數與重試的最小可行規則。

### 決策
- 漂移輸入要優先保持可預測，避免玩家覺得失敗來自隱藏物理或延遲。

### 交接重點
- 每個玩法物件都要列出生成條件、玩家互動、獎懲、HUD 回饋與 QA 可重現驗收；碰撞與失敗應產生明確回饋，並直接銜接重試。

## English

required keywords: gdd, mechanics, draft

### Scope
- The mechanics draft defines minimum viable rules for drift, acceleration, boost cell collection, combo chain, wave objective, hazard pattern, collision, scoring, and retry.

### Decisions
- Drift input should remain predictable so failure feels tied to player decisions rather than hidden physics or latency.

### Handoff Notes
- Every gameplay object needs spawn condition, player interaction, reward/penalty, HUD feedback, and QA-reproducible acceptance; collision and failure need clear feedback and a direct retry path.
