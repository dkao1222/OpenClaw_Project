# Mechanics Rules

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: mechanics, rules

### 範圍
- Mechanics Rules 只定義 drift、boost、collision、near miss、combo 的最小規則與不變條件。

### 決策
- 所有機制都必須列出 input、state、rule、output、reset condition，且不可和其他系統責任重疊。

### 交接重點
- 驗收標準是 QA 可以針對每個機制建立一個最小測試案例。

## English

required keywords: mechanics, rules

### Scope
- Mechanics Rules defines only the minimum rules and invariants for drift, boost, collision, near miss, and combo.

### Decisions
- Every mechanic must list input, state, rule, output, and reset condition without overlapping ownership with other systems.

### Handoff Notes
- Acceptance requires QA to create one minimal test case per mechanic.
