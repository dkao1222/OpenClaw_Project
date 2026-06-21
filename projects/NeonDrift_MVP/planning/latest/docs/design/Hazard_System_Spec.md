# Hazard System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

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
