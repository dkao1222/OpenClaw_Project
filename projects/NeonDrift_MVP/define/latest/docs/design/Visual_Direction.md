# Visual Direction

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

required keywords: visual, direction

### 範圍
- Visual Direction 只定義 NeonDrift 的視覺華麗度目標、美術語言與可讀性界線，不替代 UI layout 或工程實作。

### 決策
- 最低華麗度門檻是 neon arcade presentation：多層背景、發光賽道材質、cyan/magenta lane identity、可讀障礙輪廓、boost cell 高價值視覺、combo pulse、near-miss streak 與 failure flash。

### 交接重點
- 必須列出 art asset list：background layers、track materials、vehicle silhouette、hazard shapes、boost cell、HUD frame、button/icon style、score typography、settings icon、pause icon、retry icon；並列出 reduced-motion fallback、iPhone SE 2/3 與 readability acceptance。

## English

required keywords: visual, direction

### Scope
- Visual Direction defines NeonDrift's visual richness target, art language, and readability boundaries; it does not replace UI layout or engineering implementation.

### Decisions
- The minimum polish bar is neon arcade presentation: layered backgrounds, glowing track materials, cyan/magenta lane identity, readable hazard silhouettes, high-value boost cell visuals, combo pulse, near-miss streak, and failure flash.

### Handoff Notes
- It must list an art asset list: background layers, track materials, vehicle silhouette, hazard shapes, boost cell, HUD frame, button/icon style, score typography, settings icon, pause icon, retry icon, reduced-motion fallback, iPhone SE 2/3, and readability acceptance.
