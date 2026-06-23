# Hazard System Spec

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

required keywords: hazard, system, spec

### 範圍
- Hazard System 只負責障礙生成、位置、頻率與可讀警示，不負責碰撞結果或分數計算。

### 決策
- 障礙密度由 speed tier 影響，生成位置必須保留最小反應時間與安全通道，危險色不可和獎勵或 boost 色混淆。

### 交接重點
- 驗收標準是每個 hazard pattern 都能被玩家在目標裝置上辨識，且失敗前至少有一次清楚視覺提示。

## English

required keywords: hazard, system, spec

### Scope
- The Hazard System owns obstacle spawning, placement, frequency, and readable warning cues; it does not own collision outcome or scoring.

### Decisions
- Hazard density responds to speed tier, spawn positions must preserve minimum reaction time and safe lanes, and danger color must not conflict with reward or boost color.

### Handoff Notes
- Acceptance requires every hazard pattern to be readable on target devices, with at least one clear visual cue before failure.
