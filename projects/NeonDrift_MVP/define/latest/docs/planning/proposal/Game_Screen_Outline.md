# Proposal Card: Game Screen Outline

## 繁體中文

### 遊戲畫面輪廓
- 直式 iPhone 畫面以中央 dark track 為主體，左右邊緣用 cyan/magenta light strip 表示 lane limit，vehicle 位於下半部中央偏上，hazard/boost 從上方進入，bottom controls 固定為 LEFT/RIGHT。
- HUD 放置：top-left 顯示 SCORE 與 combo，top-right 顯示 PULSE/boost charge，pause 在右上但避開 Dynamic Island/safe area，Best score 只在 menu 或 failure overlay 中顯示。
- Start menu 不是遮住整個遊戲的黑盒；它必須讓玩家看得到 game title、Start、Settings，以及背景 track preview。Start 後 overlay 必須完全離場，不得殘留擋住 gameplay。

### 畫面層次
- Layer 1 background：深色但不可黑屏，需有 subtle grid、parallax streak 或 glow gradient，讓 QA 影片能看出場景存在。
- Layer 2 track：中央可玩區域要有可辨識長條 track、左右 light border、safe lane cue；track 可以垂直流動或用 speed line 表示前進感。
- Layer 3 gameplay objects：player vehicle、hazard、boost cell 要使用不同形狀與高對比色；不能只有同色方塊，不能與背景融合。
- Layer 4 feedback/VFX：drift trail、pickup flash、hazard warning、collision flash、pulse warning 至少要覆蓋主要互動事件。
- Layer 5 HUD/modal：HUD 不可被 notch、Dynamic Island、failure overlay 或 VFX 遮擋；modal 出現時仍要讓玩家看出背景與失敗原因。

### 可讀性邊界
- iPhone SE portrait 是最低可讀基準；score/pulse 字高、button touch area、failure text、retry button 必須可操作且不重疊。
- Effects 不得遮住 vehicle、hazard、boost、buttons、failure reason；如果畫面錄影呈現黑屏、純色背景、沒有可動物件、Start overlay 疊在 gameplay 上，QA 必須判定失敗。

### 下游取用規則
- UI/UX、art、development 必須把這張卡當作第一畫面契約；若無法實作完整視覺華麗度，至少保留 five-layer readability、drift feedback、hazard/boost differentiation。

## English

### Game Screen Outline
- Portrait iPhone screen uses a central dark track, cyan/magenta lane borders, lower-mid player vehicle, top-entering hazards/boosts, and fixed bottom LEFT/RIGHT controls.

### Screen Layers
- Required layers: visible dark background, readable track, differentiated gameplay objects, event feedback/VFX, and safe-area aware HUD/modal.

### Readability Boundaries
- iPhone SE portrait is the floor. QA fails black screen, flat-color-only scene, no moving objects, gameplay hidden by Start overlay, or unreadable controls.

## Game Quality Alignment

- Quality cards read: game_quality/ROUTING.md, GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, VISUAL_ART_REFERENCE.md, QUALITY_RUBRIC.md, VALIDATION_GATES.md, GOOD_BAD_EXAMPLES.md.
- Gameplay depth evidence: player objective, first 10 seconds, risk/reward, combo/boost, failure reason, HUD feedback, and QA evidence are bounded for downstream planning.
- Visual richness evidence: VISUAL_RICHNESS.md defines screen layers, track material, VFX/motion, typography/icon direction, readability, and target-device constraints.
- Blockers: fail if the document only uses unsupported adjectives without measurable implementation evidence without concrete player action, system response, feedback, failure, and QA proof.

## Game System Design Alignment

- System design cards read: game_system_design/ROUTING.md, GAME_DEV_BLACK_BOOK_REFERENCE.md, GDD_STRUCTURE_REFERENCE.md, GAME_MECHANICS_REFERENCE.md, GAME_TERMINOLOGY_REFERENCE.md, SYSTEM_PLANNER_ROLE.md, DESIGN_METHODS.md, VALIDATION_GATES.md.
- GAME_DEV_BLACK_BOOK_REFERENCE.md used: user-centric reverse deduction, MDA mapping, player agency, FTUE, sensory validation, MVP loop, and QA evidence are preserved.
- GDD_STRUCTURE_REFERENCE.md used: Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan are converted into bounded planning commitments.
- Implementation readiness: downstream agents must receive enough player action, input/state/rule/output, feedback, risk, reset, and acceptance detail to avoid inventing core gameplay during development.
