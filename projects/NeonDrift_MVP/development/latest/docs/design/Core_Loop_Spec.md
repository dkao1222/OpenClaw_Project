# Core Loop Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: core, loop, spec

### 範圍
- Core Loop Spec 只定義 Start Run -> Drive/Drift -> Risk/Score -> Failure -> Retry 的狀態順序與退出條件。

### 決策
- 每個 loop 節點都要有 player intent、system response、feedback event、success/failure condition 與下一狀態。

### 交接重點
- 驗收標準是工程可以用狀態機實作完整短局，不需要回查大型 GDD。

## English

required keywords: core, loop, spec

### Scope
- Core Loop Spec defines only the Start Run -> Drive/Drift -> Risk/Score -> Failure -> Retry state order and exit conditions.

### Decisions
- Each loop node needs player intent, system response, feedback event, success/failure condition, and next state.

### Handoff Notes
- Acceptance requires engineering to implement the short-session state machine without rereading a large GDD.
