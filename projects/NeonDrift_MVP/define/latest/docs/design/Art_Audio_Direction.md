# Art Audio Direction

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

required keywords: art, audio, direction

### 範圍
- Art Audio Direction 只定義 art direction、audio identity、VFX/audio event pairing 與交付資產邊界，不新增核心玩法。

### 決策
- 視覺華麗度目標採 neon arcade presentation：background layers、track materials、particle/VFX budget、typography style、icon style、motion polish、screen composition 與 minimum polish bar 必須可交付。

### 交接重點
- VFX/audio event pairing 至少涵蓋 start sting、drift trail、boost cell pickup、combo pulse、near-miss streak、score tick、collision hit、failure flash、retry transition，並受 performance budget 管控。

## English

required keywords: art, audio, direction

### Scope
- Art Audio Direction defines art direction, audio identity, VFX/audio event pairing, and asset delivery boundaries without adding core gameplay.

### Decisions
- The visual richness target uses neon arcade presentation: background layers, track materials, particle/VFX budget, typography style, icon style, motion polish, screen composition, and minimum polish bar must be deliverable.

### Handoff Notes
- VFX/audio event pairing must cover start sting, drift trail, boost cell pickup, combo pulse, near-miss streak, score tick, collision hit, failure flash, retry transition, and the performance budget.
