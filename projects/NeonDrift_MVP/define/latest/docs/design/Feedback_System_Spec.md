# Feedback System Spec

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

required keywords: feedback, system, spec

### 範圍
- Feedback System 只負責 HUD、SFX、haptics、camera response 與 VFX 事件映射，不改變核心玩法狀態。

### 決策
- Start、drift、boost、near miss、score tick、collision、retry 都必須有對應 feedback event，且 reduced motion 有降級方案。

### 交接重點
- VFX 需要定義 lane glow、boost pickup burst、combo pulse、near-miss streak、failure flash 與 retry transition，並受 particle/VFX budget 控制。

## English

required keywords: feedback, system, spec

### Scope
- The Feedback System owns HUD, SFX, haptics, camera response, and VFX event mapping without changing core gameplay state.

### Decisions
- Start, drift, boost, near miss, score tick, collision, and retry must each have a feedback event, with a reduced-motion fallback.

### Handoff Notes
- VFX needs lane glow, boost pickup burst, combo pulse, near-miss streak, failure flash, and retry transition, controlled by the particle/VFX budget.
