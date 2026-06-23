# Game Design Overview

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

required keywords: game, design, overview

### 範圍
- Game Design Overview 只定義 NeonDrift MVP 的產品級遊戲承諾、平台邊界與不做事項，不承擔細節系統規則。

### 決策
- 遊戲承諾是 iPhone-first 短局霓虹漂移，玩家能快速理解、立即失敗、立即重試並看見技巧成長。

### 交接重點
- 畫面承諾是高可讀的 neon arcade presentation，不可只用單色背景與靜態方塊交付；visual richness 必須服務速度感、風險感與重試動機。

## English

required keywords: game, design, overview

### Scope
- Game Design Overview defines only the product-level game promise, platform boundary, and non-goals for NeonDrift MVP; it does not own detailed system rules.

### Decisions
- The promise is an iPhone-first short-session neon drift game where players understand quickly, fail quickly, retry immediately, and see skill growth.

### Handoff Notes
- The screen promise is a readable neon arcade presentation, not a single-color background with static blocks; visual richness must support speed, risk, and retry motivation.
